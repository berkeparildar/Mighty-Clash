using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IBase
{
    int HitPoints { get; set; } 
    int AttackRange { get; }
    int AttackSpeed { get; }
    int Damage { get; }
    
    void RangeCheck(int attackRange);
    void Attack(IUnit targetUnit);
    void TakeDamage(int damage);
    void Die();
}
