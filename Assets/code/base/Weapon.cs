using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    public Player owner;
    public int damage = 0;
    private float wait;
    public float cooldown = 0;
    private bool canAttack = true;
    protected abstract void PerformAttack();
    protected abstract void IdleWeapon();

    private void Start()
    {
        wait = cooldown;
        RenderUtils.colorizeBlue(GetComponent<Renderer>());
    }

    private void Update()
    {
        if(canAttack && Input.GetButtonDown("Attack"))
        {
            canAttack = false;
            PerformAttack();           
        }
        else if(!canAttack)
        {
            wait -= 1;
            if (wait <= 0)
            {                
                wait = cooldown;                
                canAttack = true;
                IdleWeapon();
            }
        }
    }

    public int getDamage()
    {
        return damage;
    }
}