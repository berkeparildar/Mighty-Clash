using UnityEngine;
using UnityEngine.AI;

public class Unit : MonoBehaviour, IUnit
{
    public int ElixirCost { get; protected set; }
    public int HitPoints { get; protected set; }
    public float Speed { get; protected set; }
    public int MaxHitPoints { get; protected set; }
    public int AttackRange { get; protected set; }
    public int AttackSpeed { get; protected set; }
    public int Damage { get; protected set; }
    public bool IsInTowerRange { get; }

    public virtual void Deploy(Vector3 targetPosition)
    {
    }

    public void Movement(float speed, NavMeshAgent navMeshAgent
        , Transform baseTransform)
    {
        navMeshAgent.speed = speed;
        if (baseTransform.gameObject.CompareTag("EnemyBase"))
        {
            navMeshAgent.SetDestination(
                Vector3.Distance(transform.position,
                    baseTransform.position) <
                5 + AttackRange
                    ? transform.position
                    : baseTransform.position);
        }
        else if (baseTransform.gameObject.CompareTag("EnemyUnit"))
        {
            if (Vector3.Distance(transform.position,
                    baseTransform.position) <
                AttackRange)
                navMeshAgent.SetDestination(transform.position);
            else
                navMeshAgent.SetDestination(baseTransform.position);
        }
    }

    public virtual void RangeCheck(int attackRange)
    {
        throw new System.NotImplementedException();
    }

    public virtual void Attack(IUnit targetUnit)
    {
    }

    protected Transform BaseCheck(Transform leftBase, Transform rightBase)
    {
        var position = transform.position;
        Transform returnBase = null;
        var distanceToLeft = Vector3.Distance(position, leftBase.position);
        var distanceToRight = Vector3.Distance(position, rightBase.position);
        if (distanceToLeft < distanceToRight)
            returnBase = leftBase;
        else if (distanceToRight < distanceToLeft) returnBase = rightBase;

        return returnBase;
    }

    public void TakeDamage(int damage)
    {
        HitPoints -= damage;
        if (HitPoints <= 0) Die();
    }

    public void Die()
    {
        Destroy(this);
    }
}