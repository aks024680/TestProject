using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class 建築 : MonoBehaviour
{
    bool E_bool = false;
    GameObject Temp;
    public GameObject 椅子;
    public float 距離 = 10;
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
                E_bool = true;
            }
        }
        if (!Input.GetKeyDown(KeyCode.E) && E_bool == true)
        {
            Vector3 t = transform.TransformDirection(transform.localPosition* 15) ;
            Debug.DrawRay(transform.position, t,Color.black);



            //if (Physics.Raycast(ray, out hit, 距離))
            //{
            //    Temp.transform.localPosition = hit.point;
            //}
        }
    }
}
