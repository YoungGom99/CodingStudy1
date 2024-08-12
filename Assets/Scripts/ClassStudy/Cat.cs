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
        // 참조형
        Cat cat = new Cat();
        cat.name = "별이";

        Cat cat2 = cat;
        cat2.name = "삐약이"; // cat.name = 삐약이

        // 값형
        int a = 5;
        int b = a;

        b = 10; // a = 5, b = 10
    }

    private void Update()
    {
        // Cat cat = new Cat();
    }
}
