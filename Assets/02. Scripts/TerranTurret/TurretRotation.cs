using UnityEngine;

public class TurretRotation : MonoBehaviour
{
    public float rotSpeed;
          
    void Update()
    {
        transform.Rotate(Vector3.up * rotSpeed * Time.deltaTime);
    }
}
