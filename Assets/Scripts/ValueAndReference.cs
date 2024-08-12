using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class ValueAndReference : MonoBehaviour
{
    int valueType; // �ʱ�ȭ ���� ���� 0

    public struct Point
    {
        public float x; 
        public float y;
        public float z;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // ������
        Cat cat = new Cat();
        cat.name = "����";

        Cat cat2 = cat;
        cat2.name = "�߾���"; // cat.name = �߾���

        // ����
        int a = 5;
        int b = a;

        b = 10; // a = 5, b = 10

        Vector3 vector3 = new Vector3(1, 2, 3);
        vector3 = Vector3.right;


        // �ڽ�, ��ڽ� �ݺ��� ������� -> ó������ �뵵�� �°� Ÿ���� ���� ������Ѵ�.
        object value = 132; // Heap�� ����Ǿ��ִ� �� 132
        int value2 = (int)value; // Heap -> Stack(��ڽ�), Heap�� �ּ� value�� ���� stack�� ���� ����
        object value3 = value2; // Stack -> Heap(�ڽ�)

        List<int> numbers = new List<int>();
        // int num = numbers[0];

    }

    // Update is called once per frame
    void Update()
    {
        // ������ �߻� -> ������� �߻�
        // Cat cat = new Cat();
    }
}
