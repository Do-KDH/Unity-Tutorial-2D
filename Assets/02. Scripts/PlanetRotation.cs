using UnityEngine;

public class PlanetRotation : MonoBehaviour
{
    public Transform targetPlanet;

    public float rotSpeed = 30f;  // 자전 속도

    public float revolutionSpeed = 100f;  // 공전 속도

    public bool isRevolution = false;
        
    void Update()
    {
        transform.Rotate(transform.up * rotSpeed * Time.deltaTime); // 자전 기능
                
        if (isRevolution == true)
        {
            transform.RotateAround(targetPlanet.position, transform.up, revolutionSpeed * Time.deltaTime);  
        }
    }
}
