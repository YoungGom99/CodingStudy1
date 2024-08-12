using TMPro;
using UnityEngine;

public class MovingObject : MonoBehaviour
{
    public Transform from;
    public Transform to;
    [Range(0f, 1f)]
    public float ratio = 0;
    public float duration = 3;
    float currenTime;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    bool isLeft = false;

    public float smoothTime = 0.3F;
    private Vector3 velocity = Vector3.zero;

    // Update is called once per frame
    void Update()
    {
        currenTime += Time.deltaTime;
        print(currenTime);

        //transform.position = Vector3.Lerp(from.position, to.position, ratio);

        if (currenTime > duration)
        {
            currenTime = 0;

            isLeft = !isLeft;
        }

        if(isLeft)
        {
            transform.position = Vector3.Lerp(from.position, to.position, currenTime / duration);
            //transform.position = Vector3.SmoothDamp(transform.position, to.position, ref velocity, smoothTime);
        }
        else
        {
            transform.position = Vector3.Lerp(to.position, from.position, currenTime / duration);
        }
    }
}
