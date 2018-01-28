using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime : Enemy {
    protected override void ReceiveDamage()
    {      
        RenderUtils.colorizeRed(GetComponent<Renderer>());
    }

    protected override void RecoverFromDamage()
    {
        RenderUtils.colorizeGreen(GetComponent<Renderer>());
    }

    void Start () {       
        RenderUtils.colorizeGreen(GetComponent<Renderer>());
	}

    private void FixedUpdate()
    {
        MoveRandom();
    }

    private void MoveRandom()
    {
        var x = Random.Range(-1, 1) * Time.deltaTime * speed;
        var z = Random.Range(-1, 1) * Time.deltaTime * speed;
        transform.Translate(0, 0, z);
        transform.Rotate(0, x * 50, 0);
    }
}
