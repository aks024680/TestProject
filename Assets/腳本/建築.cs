using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class 建築 : MonoBehaviour
{
    public GameObject obj;
    // Start is called before the first frame update
    void Start()
    {

    }
    bool E_bool = false;
    GameObject copy;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (E_bool)
            {
                Destroy(copy);
                E_bool = false;
            }
            else
            {
                copy = Instantiate(obj); 
                E_bool = true;
            }

        }

    }
}
