using UnityEngine;

public class BossController : MonoBehaviour
{
    public int maxHealth = 100;
    private int currentHealth;

    public enum BossState
    {
        Idle,
        Attacking,
        Defeated
    }

    public BossState CurrentState { get; private set; }

    void Start()
    {
        currentHealth = maxHealth;
        CurrentState = BossState.Idle;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            currentHealth = 0;
            Defeat();
        }
    }

    private void Defeat()
    {
        CurrentState = BossState.Defeated;
        // Add defeat logic here, like playing an animation or dropping loot.
        Destroy(gameObject);
    }
}
