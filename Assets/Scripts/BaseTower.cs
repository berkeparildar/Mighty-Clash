using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseTower : MonoBehaviour, IBase
{
    // Start is called before the first frame update

    private void Awake()
    {
        HitPoints = 1000;
        AttackRange = 20;
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int HitPoints { get; set; }
    public int AttackRange { get; set; }
    public int AttackSpeed { get; }
    public int Damage { get; }
    public void RangeCheck(int attackRange)
    {
        throw new System.NotImplementedException();
    }

    public void Attack(IUnit targetUnit)
    {
        throw new System.NotImplementedException();
    }

    public void TakeDamage(int damage)
    {
        throw new System.NotImplementedException();
    }

    public void Die()
    {
        throw new System.NotImplementedException();
    }
}
