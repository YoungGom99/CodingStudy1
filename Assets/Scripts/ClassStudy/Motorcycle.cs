using UnityEngine;

public class Motorcycle : Vehicle
{
    // 애트리뷰트 attribute
    [SerializeField] string model;
    [SerializeField] [Range(0, 100)] float speed;
    [SerializeField] float multiplier;
    public float Speed
    {
        get { return speed; }
        set
        {
            speed = value * multiplier;
        }
    }

    [SerializeField] string sound;

    public void ChargeElectricity()
    {
        print("충전중...");
    }

    public override void Accelerate(string sound)
    {
        base.Accelerate(sound);

        TurnLightOn();
    }

    public void TurnLightOn()
    {

    }

    private void Start()
    {
        Brand = "BMW";
        base.ShowBrand();
    }
}
