using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpCube : MonoBehaviour
{
    public float JumpPawer;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(Vector3.down * (JumpPawer * Time.fixedDeltaTime));
        }
    }
}
