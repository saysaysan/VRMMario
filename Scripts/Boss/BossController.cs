using UnityEngine;

public abstract class BossController : MonoBehaviour
{
    public int maxHealth = 10;
    protected int currentHealth;

    public virtual void Start()
    {
        currentHealth = maxHealth;
    }

    public virtual void TakeDamage(int amount)
    {
        currentHealth -= amount;
        if (currentHealth <= 0)
        {
            Defeated();
        }
    }

    protected abstract void Attack();

    protected virtual void Defeated()
    {
        // Placeholder defeat logic
        Destroy(gameObject);
    }
}
