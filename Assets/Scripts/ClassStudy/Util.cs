using UnityEngine;

// ���� Ŭ����: ������ �� ���� Ŭ����
public static class Util
{
    // ���� �޼ҵ�
    public static double Add(double a, double b)
    {
        return a + b;
    }

    public static double Subtract(double a, double b)
    {
        return a - b;
    }

    public static double Multiply(double a, double b)
    {
        return a * b;
    }

    public static double Divide(double a, double b)
    {
        return a / b;
    }

    public static Vector3 CalculateInverseKinematics()
    {

        return new Vector3(0, 1, 2);
    }
}
