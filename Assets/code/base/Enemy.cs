using UnityEngine;

public abstract class Enemy : MonoBehaviour {
    public int speed;
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
            Instantiate(gameObject, new Vector3(Random.Range(-8, -1), -6, Random.Range(0, 7)), Quaternion.identity);
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
            RecoverFromDamage();
            wait = cooldown;
            canGetDamage = true;            
            Die();
        }
    }

    private void FallOff()
    {
        if (transform.position.y < -10)
        {
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
