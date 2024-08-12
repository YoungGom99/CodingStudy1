using UnityEngine;

// OOP의 특징 4. 상속
// C#은 단일상속만 가능, C++ 다중상속이 가능하다.
// 인터페이스를 통해 다중상속을 보안

// 자식클래스, 하위클래스, 파생클래스
public class Policeman : Person
{
    string policemanID = "서울시 구로구 경찰서";

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        NameInfo = "신태욱";
        city = "서울";

        // 베이스 클래스의 이름을 가져오고 싶다.
        // base.nameInfo

        ShowID();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
