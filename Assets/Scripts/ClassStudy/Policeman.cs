using UnityEngine;

// OOP�� Ư¡ 4. ���
// C#�� ���ϻ�Ӹ� ����, C++ ���߻���� �����ϴ�.
// �������̽��� ���� ���߻���� ����

// �ڽ�Ŭ����, ����Ŭ����, �Ļ�Ŭ����
public class Policeman : Person
{
    string policemanID = "����� ���α� ������";

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        NameInfo = "���¿�";
        city = "����";

        // ���̽� Ŭ������ �̸��� �������� �ʹ�.
        // base.nameInfo

        ShowID();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
