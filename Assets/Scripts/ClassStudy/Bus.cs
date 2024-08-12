using Unity.VisualScripting;
using UnityEngine;

public class Bus : Vehicle
{
    public string Model { get; private set; }

    public void ChargeGas()
    {
        print("충전중...");
    }

    private void Start()
    {
        base.Honk();
        Honk();
    }

    // 재정의: virtual(parent) - override(children)
    public override void Honk2()
    {
        base.Honk2();

        print("Bus입니당~~~");
    }

    public void DetectPerson()
    {

    }
}
