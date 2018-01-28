using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour {
    public int health;

    void Die()
    {
        if(health <= 0)
        {
            Destroy(this);
        }       
    }

    private void Update()
    {
        Die();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.GetComponent<MonoBehaviour>() is Weapon)
        {
            Weapon wep = collision.gameObject.GetComponent<MonoBehaviour>() as Weapon;
            health -= wep.getDamage();
            receiveDamage();
        }
    }

    protected abstract void receiveDamage();
}
