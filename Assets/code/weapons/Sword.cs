using UnityEngine;

public class Sword : Weapon
{
    protected override void IdleWeapon()
    {
        RenderUtils.colorizeBlue(GetComponent<Renderer>());
    }

    protected override void PerformAttack()
    {
        RenderUtils.colorizeYellow(GetComponent<Renderer>());
    }
}