using System;
using UnityEngine;
using UnityEngine.UIElements;

// OOP�� Ư¡1. ���(Inheritance) - �ڽ� Ŭ������ �θ� Ŭ������ ����� ����ϰ� �ʹ�.
// MonoBehaviour�� ��� �� ���� �߿��� ���: Life Cycle
public class PlayerController : MonoBehaviour
{
    // OOP�� Ư¡2. ĸ��ȭ(����ȭ, encapsulation): ���� ���ϴ� ������ ���̰ų� ������ �ʰ� �ϰ� �ʹ�.
    private string name;
    public int speed;
    public float rotSpeed;
    public GameObject ��ø;
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

    // OOP�� Ư¡3. ������ - �Լ��� �����ε�
    // ��ư�� ����
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
            ��ø.transform.rotation = Quaternion.Euler(0, 90, 0);
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            ��ø.transform.rotation = Quaternion.Euler(0, 0, 0);
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

        // Gimbal Lock ���� �ڵ�
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
        // Vector3: ������ǥ / transform.forward: ������ǥ
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
