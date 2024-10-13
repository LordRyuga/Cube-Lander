using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    public Movements reference;
    public Canvas win;
    Rigidbody rb;
    public void FixedUpdate()
    {
        if (reference.WinCheck)
        {
            win.enabled = true;
            Time.timeScale = 0f;
        }
    }
}
