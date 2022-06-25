using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pedal : MonoBehaviour
{
    private Rigidbody rb;
    private Vector3 angle;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        angle = new Vector3(0, 100, 0);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("A");
        }
    }

    private void FixedUpdate()
    {
        RotPedal();
    }

    private void RotPedal()
    {
        rb.rotation *= Quaternion.AngleAxis(45f * Time.fixedDeltaTime, Vector3.up);
    }
}
