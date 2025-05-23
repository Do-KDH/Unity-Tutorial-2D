using System.Threading;
using UnityEngine;

public class Study_LookAt : MonoBehaviour
{
    public Transform targetTf;
    public Transform turretBody;

    public GameObject bulletPrefab;  // 총알 Prefab
    public Transform firePos; // 발사 위치     

    public float timer;
    public float cooldownTime;

    void Start()
    {
        targetTf = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        turretBody.LookAt(targetTf);

        timer += Time.deltaTime;
        if (timer >= cooldownTime)
        {
            timer = 0f;
            Instantiate(bulletPrefab, firePos.position, firePos.rotation);
        }
    }
}
