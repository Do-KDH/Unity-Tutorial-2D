using UnityEngine;

public class Study_MeshObj : MonoBehaviour
{
    public GameObject obj;

    public Mesh msh;
    public Material mat;

    void Start()
    {
        obj = GameObject.CreatePrimitive(PrimitiveType.Cube);
        CreateCube("MakeCube");  //함수 실행, 호출
    }

    public void CreateCube(string name)
    {
        obj = new GameObject(name);
        /*  obj = new GameObject();
            obj.name = "Cube";   */

        obj.AddComponent<MeshFilter>();
         obj.GetComponent<MeshFilter>().mesh = msh;

        obj.AddComponent<MeshRenderer>();
         obj.GetComponent<MeshRenderer>().material = mat;

        obj.AddComponent<BoxCollider>();
    }    
}
