using UnityEngine;
using UnityEngine.UIElements;

public class 子彈 : MonoBehaviour
{
    public float 速度 = 0.1f;
    void Start()
    {

    }

    void Update()
    {
        transform.localPosition = transform.localPosition + transform.forward * 速度 * Time.deltaTime;
        if (速度 * Time.deltaTime > 40)
        {
            Debug.Log(速度 * Time.deltaTime);
            Destroy(gameObject);
        }
    }
}
