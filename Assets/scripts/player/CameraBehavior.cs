using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehavior : MonoBehaviour {
    public GameObject player;
    private float offsetX = -4;
    private float offsetZ = -4;
    public float maximumDistance = 2;
    public float playerVelocity = 10;
    private float movementX;
    private float movementZ;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        movementX = ((player.transform.position.x + offsetX - this.transform.position.x)) / maximumDistance;
        movementZ = ((player.transform.position.z + offsetZ - this.transform.position.z)) / maximumDistance;
        this.transform.position += new Vector3(movementX * playerVelocity * Time.deltaTime, 0, movementZ * playerVelocity * Time.deltaTime);
	}
}
