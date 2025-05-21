using UnityEngine;

public class Study_Component : MonoBehaviour
{
    public GameObject obj; // Cube 게임 오브젝트를 가져오기
    public string changeName; // 유니티에서 설정할 문자열(이름) 변수

    void Start()
    {
        obj = GameObject.Find("Main Camera");

        obj.name = changeName;
    }
}
