using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class 建築 : MonoBehaviour
{
    public GameObject 椅子;
    // Start is called before the first frame update
    void Start()
    {

    }
    bool E_bool = false;
    GameObject Temp;
    // Update is called once per frame
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
            if (Physics.Raycast(ray, out hit, 100f))
            {
                Temp.transform.localPosition = hit.point; 
            }           
        }
    }
}
