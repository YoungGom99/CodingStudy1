using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float rotSpeed = 300;
    float rotValue;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float inputY = Input.GetAxis("Mouse Y");

        rotValue = rotValue + inputY * rotSpeed * Time.deltaTime;

        rotValue = Mathf.Clamp(rotValue, -90, 90);

        Quaternion rot = Quaternion.Euler(-rotValue, 0f, 0f);

        transform.localRotation = rot;
    }
}
