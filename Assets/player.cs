using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {
    private Rigidbody rigidbody;
    private float speed = 10;

	// Use this for initialization
	void Start () {
        GetComponent<Renderer>().material.color = new Color(1, 0.5f, 0.5f);
        rigidbody = GetComponent<Rigidbody>();      
	}

    void FixedUpdate() {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rigidbody.AddForce(movement * speed);
    }

    // Update is called once per frame
    void Update () {      
    }
}
