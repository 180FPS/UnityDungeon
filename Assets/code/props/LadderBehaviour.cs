using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class LadderBehaviour : MonoBehaviour {
    public Player player;
    public float distanceToClimb;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float distance = Vector3.Distance(player.transform.position, transform.position);
        print(distance);
        if(distance < distanceToClimb)
        {
            //  We can climb the stair.
            RenderUtils.colorizeBlue(GetComponent<Renderer>());           
            player.SetMovement(false);
            player.transform.Translate(0, 10 * Time.deltaTime, 0);
        }
        else
        {
            player.SetMovement(true);
            RenderUtils.colorizeLightBlue(GetComponent<Renderer>());
        }
	}
}
