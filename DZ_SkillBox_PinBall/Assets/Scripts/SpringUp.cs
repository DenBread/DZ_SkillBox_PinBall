using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpringUp : MonoBehaviour
{
    [SerializeField] private ConfigurableJoint platformJoint;
    private Vector3 _targetPos = new Vector3(0f, 3f);
    private Vector3 _startPos = new Vector3(0f, 0f);

    private void OnCollisionStay(Collision collisionInfo)
    {
        if (collisionInfo.gameObject.tag == "SpherePinBall")
        {
            platformJoint.targetPosition = _targetPos;
        }
    }

    private void OnCollisionExit(Collision other)
    {
        platformJoint.targetPosition = _startPos;
    }
}
