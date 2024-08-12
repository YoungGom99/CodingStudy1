using UnityEngine;

public class Manager : MonoBehaviour
{
    public Person thePerson;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        thePerson = FindAnyObjectByType<Person>();
        print("�̸���: " + thePerson.NameInfo + "���̴�: " + thePerson.age);

        thePerson.ShowID(); // �Ϲݸ޼ҵ�
        int result = Person.Add(3, 5); // �����޼ҵ� ���
        print(result);

        Util.Add(5, 6);
        Util.CalculateInverseKinematics();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
