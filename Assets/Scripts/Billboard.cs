using UnityEngine;

/// <summary>
/// 常にカメラの方を向くオブジェクト回転をカメラに固定
/// </summary>
public class Billboard : MonoBehaviour {
	private void LateUpdate() {
		// 回転をカメラと同期させる
		transform.rotation = Camera.main.transform.rotation;
	}
}
