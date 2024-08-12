using System;
using UnityEngine;
using UnityEngine.UIElements;

// OOP의 특징1. 상속(Inheritance) - 자식 클래스는 부모 클래스의 기능을 사용하고 싶다.
// MonoBehaviour의 기능 중 가장 중요한 기능: Life Cycle
public class PlayerController : MonoBehaviour
{
    // OOP의 특징2. 캡슐화(은닉화, encapsulation): 내가 원하는 내용을 보이거나 보이지 않게 하고 싶다.
    private string name;
    public int speed;
    public float rotSpeed;
    public GameObject 경첩;
    public Light[] lights;
    float xRot;
    float yRot;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveByAxes();

        //MoveByArrow();

        RotateCharacter();

        OpenCloseDoor();

        TurnOnOffLights();
    }

    bool isLightsOn = false;
    private void TurnOnOffLights()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            isLightsOn = !isLightsOn; // true -> false -> true -> false

            foreach (Light light in lights)
            {
                light.intensity = (isLightsOn) ? 30 : 0;
            }
        }
    }

    // OOP의 특징3. 다형성 - 함수의 오버로드
    // 버튼에 연결
    public void TurnOnOffLights(bool isOn)
    {
        foreach (Light light in lights)
        {
            light.intensity = (isOn) ? 30 : 0;
        }
    }


    private void OpenCloseDoor()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            경첩.transform.rotation = Quaternion.Euler(0, 90, 0);
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            경첩.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }

    private void RotateCharacter()
    {
        float mouseX = Input.GetAxis("Mouse X");
        //float mouseY = Input.GetAxis("Mouse Y");

        xRot += mouseX * rotSpeed * Time.deltaTime;
        //yRot += mouseY * rotSpeed * Time.deltaTime;
        Quaternion rot = Quaternion.Euler(0, xRot, 0);
        transform.rotation = rot;

        // Gimbal Lock 유발 코드
        //xRot = mouseX * rotSpeed * Time.deltaTime;
        //yRot = mouseY * rotSpeed * Time.deltaTime;
        //Quaternion rot = Quaternion.Euler(-yRot, xRot, 0);
        //transform.rotation *= rot;
    }

    private void MoveByAxes()
    {
        float hValue = Input.GetAxis("Horizontal");
        float vValue = Input.GetAxis("Vertical");

        Vector3 direction = (transform.forward * vValue) + (transform.right * hValue);

        transform.position += direction * speed * Time.deltaTime;
    }

    private void MoveByArrow()
    {
        // Vector3: 절대좌표 / transform.forward: 로컬좌표
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position = transform.position + transform.forward * speed * Time.deltaTime;
            // P = P0 + VT
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position = transform.position - transform.forward * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position = transform.position + transform.right * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position = transform.position - transform.right * speed * Time.deltaTime;
        }
    }
}
