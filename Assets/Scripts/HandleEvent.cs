using UnityEngine;

// Handle이 움직이고 있을 때, Ball과 충돌하면 True, 그렇지 않으면 False로 설정한다.
public class HandleEvent : MonoBehaviour
{
    //public GameManager GameManager;
    public bool isBallTouching = false;
    public int score = 100;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ball")
        {
            print("공 충돌!");
            isBallTouching = true;
        }

        // 내가 스코어 오브젝트라면
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
