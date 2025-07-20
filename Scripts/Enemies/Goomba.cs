using UnityEngine;

public class Goomba : Enemy
{
    public float patrolDistance = 2f;
    private Vector3 startPos;
    private int direction = 1;

    protected override void Start()
    {
        base.Start();
        startPos = transform.position;
    }

    protected override void Patrol()
    {
        transform.Translate(Vector3.forward * moveSpeed * direction * Time.deltaTime);
        if (Vector3.Distance(startPos, transform.position) >= patrolDistance)
        {
            direction *= -1;
            transform.rotation = Quaternion.Euler(0, transform.rotation.eulerAngles.y + 180f, 0);
        }
    }
}
