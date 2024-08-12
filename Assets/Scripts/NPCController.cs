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
        // ��������(Linear Interpolation)

        MoveToTarget();
    }

    private void MoveToTarget()
    {
        // 1. ���� tartget position���� speed�� �ӵ��� �̵��Ѵ�.
        Vector3 targetVector = tempPos - transform.position;
        float distance = targetVector.magnitude;
        Vector3 direction = targetVector.normalized;

        // �ǽ� 2. ���࿡ target position�� ���� �Ÿ��� 1 �̳��̸� �����.
        if (distance <= 1)
        {
            isSwitching = !isSwitching;

            // �ǽ� 3. Ÿ�� -> ó����ġ -> Ÿ�� -> ó����ġ �պ��
            tempPos = (isSwitching == true) ? originPos : targetPos.position;
            return;
        }

        transform.forward = direction;
        transform.position += direction * speed * Time.deltaTime;
    }
}
