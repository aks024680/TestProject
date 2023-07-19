using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class 建築 : MonoBehaviour
{
    bool E_bool = false;
    GameObject Temp;
    public float 距離 = 5;
    public GameObject 椅子;
    public GameObject gobj_super;

    void Start()
    {

    }
    void Update()
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
                Temp = Instantiate(椅子);
                Temp.transform.parent = gobj_super.transform;
                E_bool = true;
            }
        }
        if (!Input.GetKeyDown(KeyCode.E) && E_bool == true)
        {
            Debug.DrawRay(transform.position, transform.forward * 距離, Color.black);

            Temp.transform.position = transform.forward * 距離;

            //if (Physics.Raycast(ray, out hit, 距離))
            //{
            //    Temp.transform.localPosition = hit.point;
            //}
            //else
            //{
            //    Temp.transform.position = transform.forward * 距離;
            //}
        }
    }
}
