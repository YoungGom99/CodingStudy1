using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.XR;

public class Vehicle : MonoBehaviour
{
    [SerializeField] private string brand;
    //public string Brand {  get; set; }

    // ������Ƽ
    public string Brand
    {
        get
        {
            return brand;
        }
        set
        {
            brand += "1234";
            brand = value;
        }
    }

    public string Name { get; set; }

    private void Start()
    {
        Brand = "����";
        print(Brand);
    }

    public void ShowBrand()
    {
        print(Brand);
    }

    public void Honk()
    {
        print("Honking...");
    }

    // ������. �����Ǹ� ���� �޼���
    public virtual void Honk2()
    {
        print("Honking2...");
    }

    public virtual void Accelerate(string sound)
    {
        print(sound);
    }

    public void Break()
    {

    }


}
