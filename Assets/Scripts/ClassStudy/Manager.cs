using UnityEngine;

public class Manager : MonoBehaviour
{
    public Person thePerson;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        thePerson = FindAnyObjectByType<Person>();
        print("이름은: " + thePerson.NameInfo + "나이는: " + thePerson.age);

        thePerson.ShowID(); // 일반메소드
        int result = Person.Add(3, 5); // 정적메소드 사용
        print(result);

        Util.Add(5, 6);
        Util.CalculateInverseKinematics();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
