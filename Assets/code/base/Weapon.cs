using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    public Player owner;
    public int damage = 0;
    private float wait;
    public float cooldown = 0;
    public bool isAttacking = false;
    private bool canAttack = true;
    protected abstract void PerformAttack();
    protected abstract void IdleWeapon();

    private void Start()
    {
        wait = cooldown;
        RenderUtils.ColorizeBlue(GetComponent<Renderer>());
    }

    private void Update()
    {
        if(canAttack && Input.GetButtonDown("Attack"))
        {
            isAttacking = true;            
            owner.canMove = false;
            PerformAttack();
            canAttack = false;
        }
        else if(!canAttack)
        {
            wait -= 1;
            if (wait <= 0)
            {                
                wait = cooldown;
                isAttacking = false;
                owner.canMove = true;
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