using UnityEngine;

/// <summary>
/// Defines an implementation of the Weapon class for a sword.
/// <seealso cref="Weapon"/>
/// </summary>
public class Sword : Weapon
{
    protected override void IdleWeapon()
    {
        transform.Rotate(0, 0, -45);       
        RenderUtils.ColorizeBlue(GetComponent<Renderer>());
    }

    protected override void PerformAttack()
    {
        transform.Rotate(0, 0, 45);       
        RenderUtils.ColorizeYellow(GetComponent<Renderer>());
    }
}