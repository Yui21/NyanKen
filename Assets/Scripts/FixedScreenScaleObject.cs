using UnityEngine;

public class FixedScreenScaleObject : MonoBehaviour {
	private const float INVAILD_BASE_SCALE = float.MinValue;

	/// <summary>
	/// カメラからの距離が1のときのスケール値
	/// </summary>
	[SerializeField]
	private float _baseScale = INVAILD_BASE_SCALE;

	private void Start() {
		if (_baseScale != INVAILD_BASE_SCALE) return;
		// カメラからの距離が1のときのスケール値を算出
		_baseScale = transform.localScale.x / GetDistance();
	}

	/// <summary>
	/// カメラからの距離を取得
	/// </summary>
	private float GetDistance() {
		return (transform.position - Camera.main.transform.position).magnitude;
	}

	private void LateUpdate() {
		transform.localScale = Vector3.one * _baseScale * GetDistance();
	}
}