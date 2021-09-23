using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour
{
    public GameObject camera;
    Rigidbody rigidbody;
    public float speed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rigidbody.AddForce(Vector3.forward * speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rigidbody.AddForce(Vector3.back * speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rigidbody.AddForce(Vector3.left * speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rigidbody.AddForce(Vector3.right * speed);
        }
    }
}
