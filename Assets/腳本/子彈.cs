using UnityEngine;

public class 子彈 : MonoBehaviour
{
    float 子彈距離 = 7;
    void Start()
    {

    }

    void Update()
    {
        子彈距離 += 0.05f;
        transform.position = transform.forward * 子彈距離;
        if (子彈距離 > 20)
        {
            Debug.Log(子彈距離);
            Destroy(gameObject);
        }
    }
}
