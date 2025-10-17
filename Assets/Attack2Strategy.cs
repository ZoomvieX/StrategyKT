using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack2Strategy : IAttackStrategy
{
    private Animator _animator;

    public Attack2Strategy(Animator animator)
    {
        _animator = animator;
    }

    public void PerformAttack()
    {
        _animator.SetTrigger("Attack2");
    }
}
