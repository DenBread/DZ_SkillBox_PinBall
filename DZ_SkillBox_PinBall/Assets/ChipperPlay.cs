using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChipperPlay : MonoBehaviour
{
    [SerializeField] private float pressPos = 45f;
    [SerializeField] private float restPos = 0;
    [SerializeField] private float hitStrength = 1000f;
    [SerializeField] private float chipperDamper = 10f;

    private HingeJoint chipper;
    private JointSpring spring;

    private void Start()
    {
        chipper = GetComponent<HingeJoint>();
        chipper.useSpring = true;

        spring = new JointSpring();
    }

    private void Update()
    {
        spring.spring = hitStrength;
        spring.damper = chipperDamper;

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            spring.targetPosition = pressPos;
        }

        else
        {
            spring.targetPosition = restPos;
        }

        chipper.spring = spring;
    }
}
