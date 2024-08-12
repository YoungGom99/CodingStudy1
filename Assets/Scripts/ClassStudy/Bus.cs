using Unity.VisualScripting;
using UnityEngine;

public class Bus : Vehicle
{
    public string Model { get; private set; }

    public void ChargeGas()
    {
        print("������...");
    }

    private void Start()
    {
        base.Honk();
        Honk();
    }

    // ������: virtual(parent) - override(children)
    public override void Honk2()
    {
        base.Honk2();

        print("Bus�Դϴ�~~~");
    }

    public void DetectPerson()
    {

    }
}
