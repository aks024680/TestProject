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
    public float 速度 = 50;
    Rigidbody rBody;
     CharacterController Cc;
    void Start()
    {
        //rBody = GetComponent<Rigidbody>();
    }
    void Update()
    {
        float x = Input.GetAxis("Horizontal") * 速度;
        float z = Input.GetAxis("Vertical") * 速度;
        //float y = 0;
        //if (ToBoolean(Input.GetAxis("Jump")) && (地板Collision == true))
        //{
        //    y = 300;
        //    地板Collision = false;
        //}
        transform.transform.Rotate(0, Input.GetAxis("Jump"), 0);
        //rBody.transform.transform.Rotate(0, Input.GetAxis("Jump"), 0);
        //transform.rotation = Quaternion.LookRotation(new(0, Input.GetAxisRaw("Jump"), 0));
        Cc = GetComponent<CharacterController>();
        Cc.Move(transform.TransformDirection(new Vector3(x, 0, z)));

        //rBody.transform.Translate(new Vector3(x, 0, z));
        //rBody.velocity = new Vector3(0, y, 0);
        //rBody.AddForce(new Vector3(x, y, z));
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