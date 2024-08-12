using System.Collections;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Game System")]
    public Rigidbody ballRigidBody;
    public Transform leftHandle;
    HandleEvent leftHandleEvent;
    public Transform rightHandle;
    HandleEvent rightHandleEvent;
    public Transform target;
    public float endAngle;
    public float startAngle;
    public float duration;
    public float powerMultiplier = 2;
    float power;
    Vector3 originPos;
    float currentTime;

    [Header("UI")]
    public TMP_Text scoreUI;
    public TMP_Text timeUI;
    public TMP_Text statusUI;
    public int score;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        originPos = ballRigidBody.transform.position;

        leftHandleEvent = leftHandle.GetComponentInChildren<HandleEvent>();
        rightHandleEvent = rightHandle.GetComponentInChildren<HandleEvent>();

        scoreUI.text = $"Score {score}";
        statusUI.transform.gameObject.SetActive(true);
        statusUI.transform.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            currentTime += Time.deltaTime;

            if (currentTime > 1)
            {
                power = 1;

                return;
            }

            power = currentTime;
            print("Max Power: " + power);
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            print("น฿ป็!");

            Vector3 direction = (target.position - ballRigidBody.position).normalized;
            ballRigidBody.AddForce(direction * power * powerMultiplier, ForceMode.Impulse);

            currentTime = 0;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            StartCoroutine(Rotate(rightHandle));
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            StartCoroutine(Rotate(leftHandle));
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ballRigidBody.transform.position = originPos;
        }
    }
    
    IEnumerator Rotate(Transform obj)
    {
        float currentTime = 0;
        while (true)
        {
            currentTime += Time.deltaTime;

            if (currentTime > duration)
            {
                currentTime = 0;
                
                break;
            }

            float angle = Mathf.Lerp(startAngle, endAngle, currentTime / duration);

            angle = obj.name.Contains("Left") ? -angle : angle;
            obj.localRotation = Quaternion.Euler(0, angle, 0);

            if (obj.name.Contains("Left") && leftHandleEvent.isBallTouching)
                ballRigidBody.AddForce(leftHandleEvent.transform.forward * 3, ForceMode.Impulse);
            else if (obj.name.Contains("Right") && rightHandleEvent.isBallTouching)
                ballRigidBody.AddForce(rightHandleEvent.transform.forward * 3, ForceMode.Impulse);

            yield return new WaitForEndOfFrame();
        }

        obj.localRotation = Quaternion.Euler(0, 0, 0);
    }
}

