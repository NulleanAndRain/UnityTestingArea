using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody rb;

    public float speed;

    // Start is called before the first frame update
    void Start() {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKey(KeyCode.W)) {
            rb.AddForce(Vector3.forward * Time.deltaTime * speed, ForceMode.VelocityChange);
		}

        if (Input.GetKey(KeyCode.S)) {
            rb.AddForce(Vector3.back * Time.deltaTime * speed, ForceMode.VelocityChange);
        }
    }
}
