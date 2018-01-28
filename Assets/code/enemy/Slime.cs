using UnityEngine;

/// <summary>
/// Defines a slow movement low-damaging enemy with near to non existant IA and poor void detection.
/// <see cref="Enemy"/>
/// </summary>
public class Slime : Enemy {
    protected override void ReceiveDamage()
    {      
        RenderUtils.ColorizeRed(GetComponent<Renderer>());
    }

    protected override void RecoverFromDamage()
    {
        RenderUtils.ColorizeGreen(GetComponent<Renderer>());
    }

    void Start () {       
        RenderUtils.ColorizeGreen(GetComponent<Renderer>());
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
