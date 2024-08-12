using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class ValueAndReference : MonoBehaviour
{
    int valueType; // 초기화 없이 값은 0

    public struct Point
    {
        public float x; 
        public float y;
        public float z;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 참조형
        Cat cat = new Cat();
        cat.name = "별이";

        Cat cat2 = cat;
        cat2.name = "삐약이"; // cat.name = 삐약이

        // 값형
        int a = 5;
        int b = a;

        b = 10; // a = 5, b = 10

        Vector3 vector3 = new Vector3(1, 2, 3);
        vector3 = Vector3.right;


        // 박싱, 언박싱 반복시 오버헤드 -> 처음부터 용도에 맞게 타입을 선언 해줘야한다.
        object value = 132; // Heap에 저장되어있는 값 132
        int value2 = (int)value; // Heap -> Stack(언박싱), Heap에 주소 value를 통해 stack에 값을 저장
        object value3 = value2; // Stack -> Heap(박싱)

        List<int> numbers = new List<int>();
        // int num = numbers[0];

    }

    // Update is called once per frame
    void Update()
    {
        // 가비지 발생 -> 오버헤드 발생
        // Cat cat = new Cat();
    }
}
