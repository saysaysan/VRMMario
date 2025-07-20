using UnityEngine;

public class Koopa : Enemy
{
    public Transform shell;
    private bool isInShell = false;

    protected override void Patrol()
    {
        if (!isInShell)
        {
            base.Patrol();
        }
    }

    public override void TakeDamage(int damage)
    {
        if (!isInShell)
        {
            isInShell = true;
            moveSpeed *= 2f;
            if (shell != null)
            {
                shell.gameObject.SetActive(true);
            }
        }
        else
        {
            base.TakeDamage(damage);
        }
    }
}
