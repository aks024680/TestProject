using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class 建築 : MonoBehaviour
{
    bool E_bool = false;
    GameObject Temp;
    public float 距離 = 7;
    public GameObject 椅子;
    public GameObject gobj_super;
    float i = 7;
    bool 移動bool = false;
    void Start()
    {

    }
    void Update()
    {
        Key();
        if (移動bool && E_bool == false)
        {
            i += 0.1f;
            Temp.transform.position = Temp.transform.position + transform.forward * i;
        }

    }

    private void Key()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (E_bool)
            {
                Destroy(Temp);
                E_bool = false;
            }
            else
            {
                i = 0;
                移動bool = false;
                Temp = Instantiate(椅子);
                Temp.transform.parent = gobj_super.transform;//放到父物件
                E_bool = true;
            }
        }
        if (Input.GetMouseButtonDown(0))//左鍵
        {
            E_bool = false;
            return;
        }

        if (Input.GetMouseButtonDown(1))//右鍵
        {
            E_bool = false;
            移動bool = true;
            return;
        }
        if (E_bool == true)
        {

            Debug.DrawRay(transform.position, transform.forward * 距離, Color.black);
            if (Physics.Raycast(ray, out hit, 距離))
            {
                //Debug.Log(hit.collider.tag);
                if (hit.collider.tag != "物品")
                {
                    Temp.transform.position = hit.point;
                }
            }
            else
            {
                Temp.transform.position = transform.position + transform.forward * 距離;
            }

        }


    }
}
