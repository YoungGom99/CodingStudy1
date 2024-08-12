using UnityEngine;

public class Explotion : MonoBehaviour
{
    Rigidbody body;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        body = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            body.AddForce(new Vector3(0, 5, 0), ForceMode.Impulse);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag != "Plane")
        {
            print(collision.gameObject.name);

            body.AddForce(new Vector3(0, 15, 0), ForceMode.Impulse);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
    }

    private void OnCollisionStay(Collision collision)
    {
    }
}
