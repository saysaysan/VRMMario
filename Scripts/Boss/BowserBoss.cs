using UnityEngine;

public class BowserBoss : BossController
{
    public float fireballInterval = 3f;
    private float nextFireTime;

    public override void Start()
    {
        base.Start();
        nextFireTime = Time.time + fireballInterval;
    }

    void Update()
    {
        if (Time.time >= nextFireTime)
        {
            Attack();
            nextFireTime = Time.time + fireballInterval;
        }
    }

    protected override void Attack()
    {
        // Placeholder attack logic
        Debug.Log("Bowser shoots a fireball!");
    }
}
