using UnityEngine;

/// <summary>
/// 指定したBounds（Renderer、またはColliderから参照）よりオブジェクトが後ろにあるときは、
/// カメラから見てBoundsの表面にオブジェクトが表示されるようにするコンポーネント
/// 座標設定はSetPositionメソッドを使わないと正しく反映されないことに注意
/// </summary>
public class FrontBoundsObject : MonoBehaviour {
	[SerializeField]
	private Renderer[] _renderers;
	[SerializeField]
	private Collider[] _colliders;

	/// <summary>
	/// 表面位置からどのくらい余裕をもって位置を離すか
	/// </summary>
	[SerializeField]
	private float _marginDistance = 0;

	private Transform _cameraT;

	public void SetBounds(Renderer[] renderers) {
		_renderers = renderers;
		_colliders = null;
	}

	public void SetBounds(Collider[] colliders) {
		_colliders = colliders;
		_renderers = null;
	}

	/// <summary>
	/// 表示の基準になる座標
	/// </summary>
	private Vector3 _baseLocalPosition;

	/// <summary>
	/// 表示の基準になる座標を設定
	/// </summary>
	public void SetPosition(Vector3 worldPosition) {
		_baseLocalPosition = transform.parent.InverseTransformPoint(worldPosition);
	}
	public void SetLocalPosition(Vector3 localPosition) {
		_baseLocalPosition = localPosition;
	}

	private void Start() {
		_cameraT = Camera.main.transform;
		_baseLocalPosition = transform.localPosition;
	}

	private void LateUpdate () {
		if (_renderers == null && _colliders == null) {
			// オブジェクト表面として、レンダラーかコライダーが設定されていなければ何もしない
			return;
		}

		// 毎フレーム位置の補正をする前に、本来の位置（_baseLocalPosition）にリセットする
		transform.localPosition = _baseLocalPosition;

		UpdateClosestPoint();

		// 表面の形状やUI次第ではUIの一部がオブジェクトにめり込むことがあるため
		// 算出した表面から更に_marginDistance分オフセットする
		transform.position -= _cameraT.forward * _marginDistance;
	}

	private void UpdateClosestPoint() {
		Vector3 mostClosestPoint;
		// 指定されているレンダラーorコライダーで、カメラに最も近い表面座標を取得
		if (_renderers != null && _renderers.Length > 0) {
			mostClosestPoint = GetClosestPoint(_renderers, _cameraT.position);
		} else {
			mostClosestPoint = GetClosestPoint(_colliders, _cameraT.position);
		}

		// UIからカメラへの方向
		Quaternion quaternion = Quaternion.LookRotation(transform.position - _cameraT.position);
		// UIの位置からまっすぐ進んで、カメラに最も近い表面座標の平面上にぶつかる位置を取得する
		Vector3 intersectPoint = CalcIntersectPoint(
			normal: quaternion * Vector3.back,
			planePosition: mostClosestPoint,
			startPosition: transform.position,
			startForward: quaternion * Vector3.forward
		);
		transform.position = intersectPoint;
	}

	// FIXME: Colliderのメソッドと一部処理が重複している
	/// <summary>
	/// 複数あるレンダラーのバウンディングボックスの中で、指定位置からもっとも近い座標を取得する
	/// </summary>
	private Vector3 GetClosestPoint(Renderer[] renderers, Vector3 position) {
		Vector3 mostClosestPoint = Vector3.zero;
		float minSqrMagnitude = float.MaxValue;

		foreach (Renderer renderer in renderers) {
			if (renderer == null) {
				continue;
			}
			// FIXME: Boundsを使っているため、厳密な表面座標が取れていない
			Vector3 closestPoint = renderer.bounds.ClosestPoint(position);
			float sqrMagnitude = (closestPoint - position).sqrMagnitude;
			if (sqrMagnitude >= minSqrMagnitude) {
				continue;
			}
			minSqrMagnitude = sqrMagnitude;
			mostClosestPoint = closestPoint;
		}

		return mostClosestPoint;
	}

	// FIXME: Rendererのメソッドと一部処理が重複している
	/// <summary>
	/// 複数あるコライダーのバウンディングボックスの中で、指定位置からもっとも近い座標を取得する
	/// </summary>
	private Vector3 GetClosestPoint(Collider[] colliders, Vector3 position) {
		Vector3 mostClosestPoint = Vector3.zero;
		float minSqrMagnitude = float.MaxValue;

		foreach (Collider collider in colliders) {
			if (collider == null) {
				continue;
			}
			// FIXME: Boundsを使っているため、厳密な表面座標が取れていない
			Vector3 closestPoint = collider.bounds.ClosestPoint(position);
			float sqrMagnitude = (closestPoint - position).sqrMagnitude;
			if (sqrMagnitude >= minSqrMagnitude) {
				continue;
			}
			minSqrMagnitude = sqrMagnitude;
			mostClosestPoint = closestPoint;
		}

		return mostClosestPoint;
	}

	/// <summary>
	/// 特定の位置からまっすぐすすんで、平面上にぶつかる位置を取得する
	/// </summary>
	/// <param name="planeUp">法線方向</param>
	/// <param name="planePosition">平面上のいずれかの座標</param>
	/// <param name="startPosition">ぶつける座標を取得する開始位置</param>
	/// <param name="startForward">ぶつける座標を取得する方向</param>
	private Vector3 CalcIntersectPoint(Vector3 normal, Vector3 planePosition, Vector3 startPosition, Vector3 startForward) {
		Vector3 n = normal;
		Vector3 x = planePosition;
		Vector3 x0 = startPosition;
		Vector3 m = startForward;
		float h = Vector3.Dot(n, x);

		Vector3 intersectPoint = x0 + ((h - Vector3.Dot(n, x0)) / (Vector3.Dot(n, m))) * m;

		return intersectPoint;
	}
}
