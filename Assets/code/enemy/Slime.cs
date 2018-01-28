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
        print(health);
        RenderUtils.colorizeGreen(GetComponent<Renderer>());
    }

    void Start () {       
        RenderUtils.colorizeGreen(GetComponent<Renderer>());
	}
}
