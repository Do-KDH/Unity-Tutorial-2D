using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Missile : MonoBehaviour
{
    public float bulletSpeed = 50f;
    public float destroyTime = 2f;

    private void Start()
    {
        Destroy(this.gameObject, destroyTime);
    }

    void Update()
    {
        transform.position += transform.up * bulletSpeed * Time.deltaTime;
    }    
}
