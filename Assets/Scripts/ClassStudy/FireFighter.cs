using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class FireFighter : Person
{
    string fireFighterID = "서울시 구로구 소방서";
    int[] stationInfo1;
    List<int> stationInfo2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        print(stationInfo1.Length);
        print(stationInfo2.Count);

        NameInfo = "홍길동";
    }
}
