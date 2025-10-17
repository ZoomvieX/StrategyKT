using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack1Strategy : IAttackStrategy
{
    private Animator _animator;

  

    public Attack1Strategy(Animator animator)
    {
        _animator = animator;
       // Debug.LogWarning("1");
    }

    public void PerformAttack()
    {
        _animator.SetTrigger("Attack1");
        Debug.LogWarning("Стратегия 1");
    }
}
