using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movements : MonoBehaviour
{

    public Rigidbody rb;
    public float z = 1.0f;
    public float jump = 1.0f;
    public bool WinCheck = false;
    public bool Jumpcheck = false;

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Platform")
        {
            Jumpcheck = false;
        }
    }


    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(0, 0, z, ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(0, 0, -z, ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-z, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(z, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            if (Jumpcheck == false)
            {
                rb.AddForce(0, jump, 0, ForceMode.Impulse);
                Jumpcheck = true;
            }
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Win")
        {
            WinCheck = true;
        }
    }
}
