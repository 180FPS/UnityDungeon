using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class LadderBehaviour : MonoBehaviour {
    public GameObject player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float distance = Vector3.Distance(player.transform.position, transform.position);
        print(distance);
        if(distance < 5)
        {
            RenderUtils.colorizeBlue(GetComponent<Renderer>());
        }
        else
        {
            RenderUtils.colorizeLightBlue(GetComponent<Renderer>());
        }
	}
}
