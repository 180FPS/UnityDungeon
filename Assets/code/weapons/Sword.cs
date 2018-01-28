using UnityEngine;

public class Sword : Weapon
{
    protected override void IdleWeapon()
    {
        transform.Rotate(45, 0, 0);
        RenderUtils.colorizeBlue(GetComponent<Renderer>());
    }

    protected override void PerformAttack()
    {
        transform.Rotate(-45, 0, 0);
        RenderUtils.colorizeRed(GetComponent<Renderer>());
    }
}