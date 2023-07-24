using UnityEngine;

public class 建築 : MonoBehaviour
{
    bool E_bool = false;
    GameObject Temp物品;
    //GameObject Temp子彈;
    public float 距離 = 7;
    public GameObject 椅子;
    public GameObject 子彈;
    public GameObject gobj_super;
    //float 子彈距離 = 7;
    //bool 子彈bool = false;
    void Start()
    {
    }
    void Update()
    {
        Key();
        Mouse();
    }
    private void Mouse()
    {
        if (Input.GetMouseButtonDown(0))//左鍵
        {
            E_bool = false;
            return;
        }

        if (Input.GetMouseButtonDown(1))//右鍵
        {
            Instantiate(子彈);
            return;
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
                Destroy(Temp物品);
                E_bool = false;
            }
            else
            {
                Temp物品 = Instantiate(椅子);
                Temp物品.transform.parent = gobj_super.transform;//放到父物件
                E_bool = true;
            }
        }
        if (E_bool == true)
        {
            Debug.DrawRay(transform.position, transform.forward * 距離, Color.black);
            if (Physics.Raycast(ray, out hit, 距離))
            {
                //Debug.Log(hit.collider.tag);
                if (hit.collider.tag != "物品")
                {
                    Temp物品.transform.position = hit.point;
                }
            }
            else
            {
                Temp物品.transform.position = transform.position + transform.forward * 距離;
            }
        }
    }
}
