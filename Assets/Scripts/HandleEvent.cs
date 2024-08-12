using UnityEngine;

// Handle�� �����̰� ���� ��, Ball�� �浹�ϸ� True, �׷��� ������ False�� �����Ѵ�.
public class HandleEvent : MonoBehaviour
{
    //public GameManager GameManager;
    public bool isBallTouching = false;
    public int score = 100;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ball")
        {
            print("�� �浹!");
            isBallTouching = true;
        }

        // ���� ���ھ� ������Ʈ���
        //GameManager.score += score;
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            isBallTouching = false;
        }
    }
}
