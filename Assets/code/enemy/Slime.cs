using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime : Enemy {
    protected override void receiveDamage()
    {
        RenderUtils.colorizeRed(GetComponent<Renderer>());
    }

    void Start () {
        RenderUtils.colorizeGreen(GetComponent<Renderer>());
	}
}
