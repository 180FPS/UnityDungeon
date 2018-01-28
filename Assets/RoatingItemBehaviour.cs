using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoatingItemBehaviour : MonoBehaviour {
	// Use this for initialization
	void Start () {
	}

    private void Update()
    {
        // Update is called once per frame
        transform.Rotate(0, 60 * Time.deltaTime, 0);
	}
}
