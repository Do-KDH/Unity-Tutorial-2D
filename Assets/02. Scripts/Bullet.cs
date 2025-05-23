using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed = 100f;
    public float destroyTime = 2f;

    private void Start()
    {
        Destroy(this.gameObject, destroyTime);
    }

    void Update()
    {
        transform.position += transform.forward * bulletSpeed * Time.deltaTime;
    }
}
