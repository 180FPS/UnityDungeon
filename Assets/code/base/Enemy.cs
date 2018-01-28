using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour {
    public int health;
    private int wait;
    protected int cooldown = 10;
    protected bool canGetDamage = true;

    protected abstract void ReceiveDamage();
    protected abstract void RecoverFromDamage();

    private void Start()
    {
        wait = cooldown;
    }

    void Die()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        ResetDamage();
        
    }

    private void ResetDamage()
    {
        if (!canGetDamage)
            wait -= 1;
        if (wait <= 0)
        {
            wait = cooldown;
            canGetDamage = true;
            RecoverFromDamage();
            Die();
        }
    }

    private void OnTriggerStay(Collider other)
    {
        string tag = other.tag;
        if (tag.Equals("weapon") && canGetDamage)
        {
            Weapon wep = other.gameObject.GetComponent<MonoBehaviour>() as Weapon;
            if (wep.isAttacking)
            {
                canGetDamage = false;
                health -= wep.getDamage();
                ReceiveDamage();
            }
        }
    }
}
