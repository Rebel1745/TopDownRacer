using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public float SpeedForce = 10f;
    public float ReverseSpeedForce = -2f;
    public float TurnTorque = -2f;

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(transform.right * SpeedForce);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(transform.forward * ReverseSpeedForce);
        }

        rb.AddTorque(transform.up * Input.GetAxis("Horizontal") * TurnTorque);
    }
}
