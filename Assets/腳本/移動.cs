using UnityEngine;

public class 移動 : MonoBehaviour
{
    public Transform 目標;
    public Transform 地板;
    public float MoveSpeed = 0.1f;
    public float MouseSpeed = 2;
    public float UpDownSpeed = 0.1f;
    CharacterController Cc;
    float Mouse_X = 0, Mouse_Y = 0;
    void Start()
    {
        //rBody = GetComponent<Rigidbody>();
    }
    void Update()
    {
        float x = Input.GetAxis("Horizontal") * MoveSpeed * Time.deltaTime;
        float z = Input.GetAxis("Vertical") * MoveSpeed * Time.deltaTime;
        float y = Input.GetAxis("UpDown") * UpDownSpeed * Time.deltaTime;
        Cursor.lockState = CursorLockMode.Locked;
        Cc = GetComponent<CharacterController>();
        Cc.Move(transform.TransformDirection(new Vector3(x, 0, z)));
        Cc.Move(new Vector3(0, y, 0));
        Mouse_X += Input.GetAxis("Mouse X") * MouseSpeed * Time.deltaTime;
        Mouse_Y += -Input.GetAxis("Mouse Y") * MouseSpeed * Time.deltaTime;
        transform.rotation = Quaternion.Euler(Mouse_Y, Mouse_X, 0);
    }
}