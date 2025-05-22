using UnityEngine;

public class Study_GameObject : MonoBehaviour
{
    public GameObject prefab;
    // public GameObject destroyObj;

    // public Vector3 pos;
    // public Quaternion rot;

    void Start()
    {
        Debug.Log("생성되었습니다.");
        CreateAmongus();

        // Destroy(destroyObj, 3f); // 매개 변수로 들어간 게임오브젝트를 파괴. 3초 뒤에
    }    

    public void CreateAmongus()  // 어몽어스 캐릭터를 생성하고 이름을 설정
    {
        // Instantiate(prefab, pos, rot).name = "어몽어스 캐릭터";
        GameObject obj = Instantiate(prefab);  // 게임 오브젝트를 생성
        obj.name = "어몽어스 캐릭터";          // 이름 설정

        Transform objTf = obj.transform;

        Debug.Log($"캐릭터의 자식 오브젝트의 수 : {obj.transform.childCount}");
        Debug.Log($"첫번째 자식 오브젝트의 이름 : {objTf.GetChild(0).name}");
                                                        // {obj.transform.GetChild(0).name}");
        Debug.Log($"마지막 자식 오브젝트의 이름 : {objTf.GetChild(objTf.childCount - 1).name}");
                                                        // {obj.transform.GetChild(obj.transform.childCount-1).name}");
    }
}
