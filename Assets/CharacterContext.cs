using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterContext
{
    private IAttackStrategy _currentStrategy;

    public void SetStrategy(IAttackStrategy strategy)
    {
        Debug.Log($"Установлена стратегия: {strategy.GetType().Name}");
        _currentStrategy = strategy;
        
    }

    public void PerformAttack()
    {
        _currentStrategy.PerformAttack();
    }
}

