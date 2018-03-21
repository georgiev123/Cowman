using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public Transform target;

    public float speed=0.2f;

    public Vector3 offset;

    private void FixedUpdate()
    {
        Vector3 laggedPos = Vector3.Lerp(transform.position , target.position + offset, speed);
        transform.position =laggedPos;

        transform.LookAt(target);
    }

}
