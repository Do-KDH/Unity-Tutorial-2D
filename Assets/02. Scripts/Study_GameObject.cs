using UnityEngine;

public class Study_GameObject : MonoBehaviour
{
    public GameObject prefab;
    // public GameObject destroyObj;

    // public Vector3 pos;
    // public Quaternion rot;

    void Start()
    {
        Debug.Log("�����Ǿ����ϴ�.");
        CreateAmongus();

        // Destroy(destroyObj, 3f); // �Ű� ������ �� ���ӿ�����Ʈ�� �ı�. 3�� �ڿ�
    }    

    public void CreateAmongus()  // ���� ĳ���͸� �����ϰ� �̸��� ����
    {
        // Instantiate(prefab, pos, rot).name = "���� ĳ����";
        GameObject obj = Instantiate(prefab);  // ���� ������Ʈ�� ����
        obj.name = "���� ĳ����";          // �̸� ����

        Transform objTf = obj.transform;

        Debug.Log($"ĳ������ �ڽ� ������Ʈ�� �� : {obj.transform.childCount}");
        Debug.Log($"ù��° �ڽ� ������Ʈ�� �̸� : {objTf.GetChild(0).name}");
                                                        // {obj.transform.GetChild(0).name}");
        Debug.Log($"������ �ڽ� ������Ʈ�� �̸� : {objTf.GetChild(objTf.childCount - 1).name}");
                                                        // {obj.transform.GetChild(obj.transform.childCount-1).name}");
    }
}
