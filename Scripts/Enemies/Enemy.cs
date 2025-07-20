using UnityEngine;

[RequireComponent(typeof(Collider))]
public class Enemy : MonoBehaviour
{
    public int maxHealth = 1;
    protected int currentHealth;
    public float moveSpeed = 2f;

    protected virtual void Start()
    {
        currentHealth = maxHealth;
    }

    protected virtual void Update()
    {
        Patrol();
    }

    protected virtual void Patrol()
    {
        // Basic left-right patrol movement
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    }

    public virtual void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    protected virtual void Die()
    {
        Destroy(gameObject);
    }
}
