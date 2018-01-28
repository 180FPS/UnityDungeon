using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : Player {
    private Vector3 direction;
    void Start()
    {
        RenderUtils.colorizeRed(GetComponent<Renderer>());    
    }
}