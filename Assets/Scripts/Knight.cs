using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Knight : Unit
{
    private NavMeshAgent _navMeshAgent;
    public Transform leftBaseTransform;
    public Transform rightBaseTransform;
    private bool _hasTarget;

    void Awake()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
        AttackRange = 1;
        MaxHitPoints = 100;
        HitPoints = 100;
        Speed = 5;
    }

    // Update is called once per frame
    void Update()
    {
        Movement(Speed, _navMeshAgent
            , BaseCheck(leftBaseTransform, rightBaseTransform));
    }

    public override void Deploy(Vector3 targetPosition)
    {
        throw new System.NotImplementedException();
    }

    public override void RangeCheck(int attackRange)
    {
    }

    public override void Attack(IUnit targetUnit)
    {
        throw new System.NotImplementedException();
    }
}