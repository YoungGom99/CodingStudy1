using UnityEngine;

// 정적 클래스: 생성할 수 없는 클래스
public static class Util
{
    // 정적 메소드
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
