using UnityEngine;

// �θ�Ŭ����, ���̽� Ŭ����
public class Person : MonoBehaviour
{
    // ������� or �ʵ�
    // public string nameInfo = "������";

    // ������Ƽ(get ������Ƽ or set ������Ƽ or get/set ������Ƽ)
    public string NameInfo { get; set; }
    public string Name { get; set; }
    public string Address { get; }
    public int age;
    protected string city;
    string hobby;
    private string id;


    // ������(�Լ��� �� ����)
    //Person()
    //{
    //    nameInfo = "���¿�";
    //    age = 20;
    //    city = "����";
    //    hobby = "�����̵庸�� Ÿ��";
    //}

    // �Լ��� �����ε�
    //Person(string name, int age, string city, string hobby)
    //{
    //    this.name = name;
    //    this.age = age;
    //    this.city = city;
    //    this.hobby = hobby;
    //}

    //~Person() 
    //{

    //}

    private void OnDestroy()
    {
        
    }

    private void Start()
    {
        name = "���¿�";
        age = 20;
        city = "����";
        hobby = "�����̵庸�� Ÿ��";

        Speak("�ȳ��ϼ���. �ݰ����ϴ�.");
    }

    private void Update()
    {
        
    }

    public void Speak(string message)
    {
        print(message);
    }

    public void Walk()
    {

    }

    public void Run()
    {

    }

    public void ShowID()
    {
        print("���̵�� " + id + "�Դϴ�.");
    }

    // newŰ���� ����(��ü ���� ����) ����� �� �ִ�.
    public static int Add(int A, int B)
    {
        return A + B;
    }
}
