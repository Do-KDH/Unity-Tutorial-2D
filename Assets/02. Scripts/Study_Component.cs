using UnityEngine;

public class Study_Component : MonoBehaviour
{
    public GameObject obj; // Cube ���� ������Ʈ�� ��������
    public string changeName; // ����Ƽ���� ������ ���ڿ�(�̸�) ����

    void Start()
    {
        obj = GameObject.Find("Main Camera");

        obj.name = changeName;
    }
}
