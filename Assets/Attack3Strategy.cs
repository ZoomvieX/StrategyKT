using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack3Strategy : IAttackStrategy
{
    private Animator _animator;

    public Attack3Strategy(Animator animator)
    {
        _animator = animator;
    }

    public void PerformAttack()
    {
        _animator.SetTrigger("Attack3");
    }
}
