using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class CatController : MonoBehaviour
{
    [SerializeField] FloatingJoystick m_FloatingJoystick;
    [SerializeField] Animator m_Animator;
    [SerializeField] float m_Speed  = 1;
    private CharacterController m_Controller;
    private Vector3 m_Direction;
    
    //public Vector3 TransformPoint(Vector3 position);  //ワールド座標からローカル座標に変換

    void Start()
    {
        m_Controller = GetComponent<CharacterController>();
    }
    
    void Update()
    {

        if(m_Direction != new Vector3(0, 0, 0))
        {
            transform.localRotation = Quaternion.LookRotation(m_Direction);
        }
        m_Animator.SetFloat("isMoving", Mathf.Max(Mathf.Abs(m_Direction.x), Mathf.Abs(m_Direction.z)));

        m_Controller.Move(m_Direction * m_Speed * Time.deltaTime);
    }

    public void FixedUpdate ()
    {
        m_Direction = Vector3.forward * m_FloatingJoystick.Vertical + Vector3.right * m_FloatingJoystick.Horizontal;
    }
}
