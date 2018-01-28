using UnityEngine;

public class Sword : Weapon
{
    protected override void IdleWeapon()
    {
        transform.Rotate(0, 0, -45);
        RenderUtils.colorizeBlue(GetComponent<Renderer>());
    }

    protected override void PerformAttack()
    {
        transform.Rotate(0, 0, 45);
        RenderUtils.colorizeRed(GetComponent<Renderer>());
    }
}