using UnityEngine;

public class Cat : Animal
{
    public string name;
    int value;

    public override void MakeSound()
    {
        Util.Add(3, 4);
    }

    public override void Run()
    {
    }

    public override void Walk()
    {
    }

    private void Start()
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
    }

    private void Update()
    {
        // Cat cat = new Cat();
    }
}
