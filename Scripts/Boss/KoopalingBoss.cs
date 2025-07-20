using UnityEngine;

public class KoopalingBoss : BossController
{
    public string koopalingName = "Lemmy";
    public float attackInterval = 2f;
    private float nextAttackTime;

    public override void Start()
    {
        base.Start();
        nextAttackTime = Time.time + attackInterval;
    }

    void Update()
    {
        if (Time.time >= nextAttackTime)
        {
            Attack();
            nextAttackTime = Time.time + attackInterval;
        }
    }

    protected override void Attack()
    {
        Debug.Log($"{koopalingName} attacks the player!");
    }
}
