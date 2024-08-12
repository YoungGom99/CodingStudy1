using UnityEngine;

public class Box : MonoBehaviour
{
    public Color sensingColor = Color.green;
    public Color originalColor = Color.white;

    private void OnTriggerEnter(Collider other)
    {
        if (tag == "Metal" && other.tag == "MetalSensor")
        {
            print("Metal�� �����Ǿ����ϴ�.");
            other.GetComponent<MeshRenderer>().material.color = sensingColor;
        }
        else if(other.tag == "LightSensor")
        {
            print("Object�� �����Ǿ����ϴ�.");
            other.GetComponent<MeshRenderer>().material.color = sensingColor;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (tag == "Metal" && other.tag == "MetalSensor")
        {
            print("Metal�� ������...");
            other.GetComponent<MeshRenderer>().material.color = sensingColor;
        }
        else if (other.tag == "LightSensor")
        {
            print("Object�� ������...");
            other.GetComponent<MeshRenderer>().material.color = sensingColor;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (tag == "Metal" && other.tag == "MetalSensor")
        {
            print("Metal�� ��������!");
            other.GetComponent<MeshRenderer>().material.color = originalColor;
        }
        else if (other.tag == "LightSensor")
        {
            print("Object�� ������!");
            other.GetComponent<MeshRenderer>().material.color = originalColor;
        }
    }
}
