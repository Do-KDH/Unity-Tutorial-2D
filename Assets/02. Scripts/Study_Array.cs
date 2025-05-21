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

        Debug.Log($"���� List�� �ִ� ������ �� : {listNumber.Count}");
        Debug.Log($"���� List�� ������ ������ : {listNumber[listNumber.Count - 1]}");

        Debug.Log($"Array�� ù��° �� : {arrayNumber[0]}");
        Debug.Log($"Array�� ����° �� : {arrayNumber[2]}");
        Debug.Log($"Array�� ������° �� : {arrayNumber[6]}");
    }
}
