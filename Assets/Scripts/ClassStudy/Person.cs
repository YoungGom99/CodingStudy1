using UnityEngine;

// 부모클래스, 베이스 클래스
public class Person : MonoBehaviour
{
    // 멤버변수 or 필드
    // public string nameInfo = "하하하";

    // 프로퍼티(get 프로퍼티 or set 프로퍼티 or get/set 프로퍼티)
    public string NameInfo { get; set; }
    public string Name { get; set; }
    public string Address { get; }
    public int age;
    protected string city;
    string hobby;
    private string id;


    // 생성자(함수의 한 종류)
    //Person()
    //{
    //    nameInfo = "신태욱";
    //    age = 20;
    //    city = "서울";
    //    hobby = "스케이드보드 타기";
    //}

    // 함수의 오버로드
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
        name = "신태욱";
        age = 20;
        city = "서울";
        hobby = "스케이드보드 타기";

        Speak("안녕하세요. 반갑습니다.");
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
        print("아이디는 " + id + "입니다.");
    }

    // new키워드 없이(객체 생성 없이) 사용할 수 있다.
    public static int Add(int A, int B)
    {
        return A + B;
    }
}
