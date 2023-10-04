using UnityEngine;
public class CameraController : MonoBehaviour
{
    public Transform player;  // プレイヤーのTransform
    public Vector3 offset;  // プレイヤーとカメラの相対位置
    public float smoothTime = 0.3f;  // カメラがプレイヤーを追跡する際のスムーズさの調整用パラメータ
    private Vector3 velocity = Vector3.zero;  // カメラ移動時の速度ベクトル
    // プレイヤー移動後にカメラ移動をさせたいので、LateUpdateを使う
    void LateUpdate()
    {
        // プレイヤーの位置にカメラを追従させる
        Vector3 targetPosition = player.position + offset;
        targetPosition.z = transform.position.z;
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
    }
}