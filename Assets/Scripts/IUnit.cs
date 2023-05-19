using UnityEngine;
using UnityEngine.AI;

public interface IUnit
{
    int ElixirCost { get; }
    int HitPoints { get; }
    float Speed { get; }
    int AttackRange { get; }
    int AttackSpeed { get; }
    int Damage { get; }

    bool IsInTowerRange { get; }

    void Deploy(Vector3 targetPosition);

    void Movement(float speed, NavMeshAgent navMeshAgent
        , Transform baseTransform);

    void RangeCheck(int attackRange);
    void Attack(IUnit targetUnit);
    void TakeDamage(int damage);
    void Die();
}