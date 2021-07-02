using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround : MonoBehaviour
{
    public GameObject lookAtObj;
    public float RotateSpeed;
    public float RotateRadius;

    static float VertAngleMax = 89.99f;

    void Update()
    {
        rotateHor(Input.GetAxis("Horizontal") * RotateSpeed);
        rotateVert(Input.GetAxis("Vertical") * RotateSpeed);
    }

	void FixedUpdate() {
        transform.position = Quaternion.Euler(0, horAngle, 0) * Quaternion.Euler(-vertAngle, 0, 0) * Vector3.forward * RotateRadius + lookAtObj.transform.position;
        transform.LookAt(lookAtObj.transform, Vector3.up);
    }

	float horAngle = 0;
    void rotateHor(float a) {
        horAngle += a;
        horAngle %= 360;
	}

    float vertAngle = 0;
    void rotateVert(float a) {
        vertAngle += a;
        vertAngle = Mathf.Clamp(vertAngle, -VertAngleMax, VertAngleMax);
	}
}
