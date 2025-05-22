using UnityEngine;

public class Study_Component : MonoBehaviour
{
    public GameObject obj; // Cube ���� ������Ʈ�� ��������
    public string changeName; // ����Ƽ���� ������ ���ڿ�(�̸�) ����

    public Transform objTf;

    void Start()
    {
        //obj = GameObject.Find("Main Camera");
        //obj.name = changeName;

        // Player �±׸� ���� ���ӿ�����Ʈ�� ã�� obj�� �Ҵ�
        obj = GameObject.FindGameObjectWithTag("Player");
        
        objTf = GameObject.FindGameObjectWithTag("Player").transform;
        // �� objTf = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

        /* ����Ƽ�� �⺻ ���� : GameObject
           ��� GameObject�� Transform ������Ʈ�� ���� */           


        /*
        Debug.Log($"<color=#FF0000>�̸� : {obj.name}</color>");
        Debug.Log($"�±� : {obj.tag}");
        Debug.Log($"��ġ : {obj.transform.position}");
        Debug.Log($"���� : {obj.transform.rotation}");
        Debug.Log($"ũ�� : {obj.transform.localScale}");
        */
        // MeshFilter, MeshRenderer ������Ʈ�� �����ؼ� mesh, material ������ Log ���
        Debug.Log($"Mesh : {obj.GetComponent<MeshFilter>().mesh}");
        Debug.Log($"Material : {obj.GetComponent<MeshRenderer>().material}");

        // obj�� MeshRenderer�� �����ؼ� Ȱ�����¸� false�� ����
        obj.GetComponent<MeshRenderer>().enabled = false;

        // obj�� GameObject�� false
        obj.SetActive(false);
    }
}
