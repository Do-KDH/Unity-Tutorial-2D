using UnityEngine;

public class Study_Component : MonoBehaviour
{
    public GameObject obj; // Cube 게임 오브젝트를 가져오기
    public string changeName; // 유니티에서 설정할 문자열(이름) 변수

    public Transform objTf;

    void Start()
    {
        //obj = GameObject.Find("Main Camera");
        //obj.name = changeName;

        // Player 태그를 가진 게임오브젝트를 찾아 obj에 할당
        obj = GameObject.FindGameObjectWithTag("Player");
        
        objTf = GameObject.FindGameObjectWithTag("Player").transform;
        // ㄴ objTf = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

        /* 유니티의 기본 단위 : GameObject
           모든 GameObject는 Transform 컴포넌트를 가짐 */           


        /*
        Debug.Log($"<color=#FF0000>이름 : {obj.name}</color>");
        Debug.Log($"태그 : {obj.tag}");
        Debug.Log($"위치 : {obj.transform.position}");
        Debug.Log($"각도 : {obj.transform.rotation}");
        Debug.Log($"크기 : {obj.transform.localScale}");
        */
        // MeshFilter, MeshRenderer 컴포넌트에 접근해서 mesh, material 데이터 Log 출력
        Debug.Log($"Mesh : {obj.GetComponent<MeshFilter>().mesh}");
        Debug.Log($"Material : {obj.GetComponent<MeshRenderer>().material}");

        // obj의 MeshRenderer에 접근해서 활성상태를 false로 변경
        obj.GetComponent<MeshRenderer>().enabled = false;

        // obj의 GameObject를 false
        obj.SetActive(false);
    }
}
