using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 5f;
    
    void Update()
    {
        // 부드럽게 증감하는 값
        //float h = Input.GetAxis("Horizontal");
        //float v = Input.GetAxis("Vertical");]
        
        // 딱 떨어지는 값
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        Vector3 dir = new Vector3(h, 0, v);
        Debug.Log($"현재 입력 : {dir}");

        transform.position += dir * moveSpeed * Time.deltaTime;
    }
}
