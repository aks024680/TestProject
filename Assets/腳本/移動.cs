using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;
using static System.Convert;
using static System.Math;


public class 移動 : MonoBehaviour
{
    bool AllCollision;
    bool 目標Collision, 地板Collision;
    public Transform 目標;
    public Transform 地板;
    public float MoveSpeed = 0.1f;
    public float MouseSpeed = 2;
    Rigidbody rBody;
    CharacterController Cc;
    float Mouse_X = 0, Mouse_Y = 0;
    void Start()
    {
        //rBody = GetComponent<Rigidbody>();
    }
    void Update()
    {
        //float y = 0;
        //if (ToBoolean(Input.GetAxis("Jump")) && (地板Collision == true))
        //{
        //    y = 300;
        //    地板Collision = false;
        //}
        //rBody.transform.transform.Rotate(0, Input.GetAxis("Jump"), 0);
        //transform.rotation = Quaternion.LookRotation(new(0, Input.GetAxisRaw("Jump"), 0));
        //rBody.transform.Translate(new Vector3(x, 0, z));
        //rBody.velocity = new Vector3(0, y, 0);
        //rBody.AddForce(new Vector3(x, y, z));
        //transform.transform.Rotate(Mouse_Y,Mouse_X , 0, Space.World);
        //Cc.Move(transform.TransformDirection(new Vector3(x, 0, z)));
        float x = Input.GetAxis("Horizontal") * MoveSpeed * Time.deltaTime;
        float z = Input.GetAxis("Vertical") * MoveSpeed * Time.deltaTime;
        float y = Input.GetAxis("UpDown") * MoveSpeed * Time.deltaTime;
        Cursor.lockState = CursorLockMode.Locked;
        Cc = GetComponent<CharacterController>();
        Cc.Move(transform.TransformDirection(new Vector3(x, 0, z)));
        Cc.Move(new Vector3(0, y, 0));
        Mouse_X += Input.GetAxis("Mouse X") * MouseSpeed * Time.deltaTime;
        Mouse_Y += -Input.GetAxis("Mouse Y") * MouseSpeed * Time.deltaTime;
        transform.rotation = Quaternion.Euler(Mouse_Y, Mouse_X, 0);
    }


    private void OnCollisionStay(Collision other)
    {
        AllCollision = true;
        switch (other.gameObject.tag)
        {
            case "目標":
                目標Collision = true;
                break;
            case "地板":
                地板Collision = true;
                break;
            default:
                break;
        }
    }

}