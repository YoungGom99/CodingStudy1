using UnityEngine;

public class NPCController : MonoBehaviour
{
    public Transform targetPos;
    Vector3 originPos;
    Vector3 tempPos;
    public float speed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        originPos = transform.position;
        tempPos = targetPos.position;
    }

    bool isSwitching = false;
    // Update is called once per frame
    void Update()
    {
        // 선형보간(Linear Interpolation)

        MoveToTarget();
    }

    private void MoveToTarget()
    {
        // 1. 내가 tartget position으로 speed의 속도로 이동한다.
        Vector3 targetVector = tempPos - transform.position;
        float distance = targetVector.magnitude;
        Vector3 direction = targetVector.normalized;

        // 실습 2. 만약에 target position과 나의 거리가 1 이내이면 멈춘다.
        if (distance <= 1)
        {
            isSwitching = !isSwitching;

            // 실습 3. 타겟 -> 처음위치 -> 타겟 -> 처음위치 왕복운동
            tempPos = (isSwitching == true) ? originPos : targetPos.position;
            return;
        }

        transform.forward = direction;
        transform.position += direction * speed * Time.deltaTime;
    }
}
