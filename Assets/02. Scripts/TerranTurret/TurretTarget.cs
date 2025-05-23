using UnityEngine;

public class TurretTarget : MonoBehaviour
{
    public Transform targetTf;
    public Transform turretBody;

    public GameObject bulletPrefab;  // 총알 Prefab
    public Transform[] firePos; // 발사 위치

    public float timer;
    public float cooldownTime;

    public float range = 5;

    void Start()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player != null)
        {
            targetTf = player.transform;
        }
    }      

    void Update()
    {   
        if (targetTf == null)
        {
            return;
        }

        float distanceToEnemy = Vector3.Distance(transform.position, targetTf.transform.position);

        if (targetTf != null && distanceToEnemy <= range)
        {
            targetTf = GameObject.FindGameObjectWithTag("Player").transform;

            turretBody.LookAt(targetTf);

            timer += Time.deltaTime;
            if (timer >= cooldownTime)
            {
                timer = 0f;
                for (int i = 0; i < firePos.Length; i++)
                {
                    Instantiate(bulletPrefab, firePos[i].position, firePos[i].rotation);
                }
            }            
        }        
    }
}
