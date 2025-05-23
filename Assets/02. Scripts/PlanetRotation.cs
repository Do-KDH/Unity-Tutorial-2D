using UnityEngine;

public class PlanetRotation : MonoBehaviour
{
    public Transform targetPlanet;

    public float rotSpeed = 30f;  // ���� �ӵ�

    public float revolutionSpeed = 100f;  // ���� �ӵ�

    public bool isRevolution = false;
        
    void Update()
    {
        transform.Rotate(transform.up * rotSpeed * Time.deltaTime); // ���� ���
                
        if (isRevolution == true)
        {
            transform.RotateAround(targetPlanet.position, transform.up, revolutionSpeed * Time.deltaTime);  
        }
    }
}
