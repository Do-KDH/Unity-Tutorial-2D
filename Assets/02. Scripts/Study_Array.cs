using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;

public class Study_Array : MonoBehaviour
{
    public int[] arrayNumber = new int[5] { 1, 2, 3, 4, 5 };

    public List<int> listNumber = new List<int>();

    void Start()
    {
        listNumber.Add(13);
        listNumber.Add(42);
        listNumber.Add(79);
        listNumber.Add(8);
        listNumber.Add(37);

        Debug.Log($"현재 List에 있는 데이터 수 : {listNumber.Count}");
        Debug.Log($"현재 List의 마지막 데이터 : {listNumber[listNumber.Count - 1]}");

        Debug.Log($"Array의 첫번째 값 : {arrayNumber[0]}");
        Debug.Log($"Array의 세번째 값 : {arrayNumber[2]}");
        Debug.Log($"Array의 여섯번째 값 : {arrayNumber[6]}");
    }
}
