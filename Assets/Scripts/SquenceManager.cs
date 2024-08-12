using NUnit.Framework.Constraints;
using System.Collections;
using UnityEngine;

// cylinder를 내가 원하는 순서에 맞게 움직인다.
// Coroutine: Co(함께), routine(일련의 작업), 순차적으로 다양한 기능을 도와주는 기능

// CylinderA
// 1. Position 0에서 3초간 대기
// 2. Position 0 -> Position 1 까지 1초 동안 이동
// 3. Position 1에서 3초간 대기
// 4. Position 2 -> Position 3 까지 2초 동안 이동
// 5. Position 2에서 3초간 대기
// 6. Position 3 -> Position 4 까지 1초 동안 이동

public class SquenceManager : MonoBehaviour
{
    // Cylinder A, Cylinder B, Cylinder C를 순차적으로 제어
    public Transform cylinderA;
    public Transform cylinderB;
    public Transform cylinderC;

    public Transform position0;
    public Transform position1;
    public Transform position2;
    public Transform position3;
    public Transform position4;
    float currentTime;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(CoSequence());
    }

    IEnumerator CoroutineFunction()
    {
        yield return null;
    }

    // 코루틴 함수
    IEnumerator CoSequence()
    {
        yield return SequenceA();
        yield return SequenceB();
        yield return SequenceC();

        IEnumerator SequenceA()
        {
            yield return MoveAtoB(cylinderA, position0, position1, 1, 3);
            yield return MoveAtoB(cylinderA, position1, position2, 2, 3);
            yield return MoveAtoB(cylinderA, position2, position3, 1, 3);
            yield return MoveAtoB(cylinderA, position3, position4, 1, 1);
            yield return MoveAtoB(cylinderA, position4, position0, 1, 1);

            /*// 1. Position 0에서 3초간 대기
            yield return new WaitForSeconds(1);

            // 2. Position 0 -> Position 1 까지 1초 동안 이동
            yield return MoveAtoB(position0, position2, 1);

            // 3. Position 1에서 3초간 대기
            yield return new WaitForSeconds(1);

            // 4. Position 1 -> Position 2 까지 2초 동안 이동
            yield return MoveAtoB(position2, position4, 1);

            // 5. Position 2에서 3초간 대기
            yield return new WaitForSeconds(1);

            // 6. Position 2 -> Position 3 까지 1초 동안 이동
            yield return MoveAtoB(position4, position1, 1);

            // 5. Position 2에서 3초간 대기
            yield return new WaitForSeconds(1);

            // 6. Position 3 -> Position 4 까지 1초 동안 이동
            yield return MoveAtoB(position1, position3, 1);

            // 5. Position 2에서 3초간 대기
            yield return new WaitForSeconds(1);

            // 6. Position 2 -> Position 3 까지 1초 동안 이동
            yield return MoveAtoB(position3, position0, 1);*/
        }

        IEnumerator SequenceB()
        {
            yield return MoveAtoB(cylinderB, position0, position2, 0.5f, 3);
            yield return MoveAtoB(cylinderB, position2, position4, 2, Random.Range(0, 3f));
            yield return MoveAtoB(cylinderB, position4, position1, 1, 0.5f);
            yield return MoveAtoB(cylinderB, position1, position3, Random.Range(0, 1f), 1);
            yield return MoveAtoB(cylinderB, position3, position0, 1, 1);
        }

        IEnumerator SequenceC()
        {
            yield return MoveAtoB(cylinderC, position4, position3, 1, Random.Range(0, 1f));
            yield return MoveAtoB(cylinderC, position3, position2, 2, 3);
            yield return MoveAtoB(cylinderC, position2, position1, Random.Range(0, 1f), 3);
            yield return MoveAtoB(cylinderC, position1, position0, 1, 1);
            yield return MoveAtoB(cylinderC, position0, position4, 1, 1);
        }
    }

    IEnumerator MoveAtoB(Transform A, Transform B, float duration)
    {
        while (true)
        {
            currentTime += Time.deltaTime;

            if (currentTime > duration)
            {
                currentTime = 0;
                break;
            }

            cylinderA.transform.position = Vector3.Lerp(A.position, B.position, currentTime / duration);

            yield return new WaitForEndOfFrame();
        }
    }

    /// <summary>
    /// delay 만큼 기다린 후, obj를 A에서 B로 duration 동안 이동한다.
    /// </summary>
    /// <param name="obj"> 물체를 넣어줍니다. </param>
    /// <param name="A"></param>
    /// <param name="B"></param>
    /// <param name="duration"></param>
    /// <param name="delay"></param>
    /// <returns> 코루틴 함수이므로 IEnumerator 형식입니다. </returns>
    IEnumerator MoveAtoB(Transform obj, Transform A, Transform B, float duration, float delay)
    {
        yield return new WaitForSeconds(delay);

        while (true)
        {
            currentTime += Time.deltaTime;

            if (currentTime > duration)
            {
                currentTime = 0;
                break;
            }

            obj.position = Vector3.Lerp(A.position, B.position, currentTime / duration);

            yield return new WaitForEndOfFrame();
        }
    }
}
