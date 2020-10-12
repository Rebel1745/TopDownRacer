using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform Target;
    public Vector3 Offset;

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = Target.position + Offset;

        transform.LookAt(Target);
    }
}
