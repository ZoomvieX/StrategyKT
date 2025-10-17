using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttackPerformer : MonoBehaviour
{
    
    [SerializeField] private Button attack1Button;
    [SerializeField] private Button attack2Button;
    [SerializeField] private Button attack3Button;
    [SerializeField] private Animator characterAnimator;

    private CharacterContext _characterContext;

    private void Awake()
    {
        _characterContext = new CharacterContext();

        // Инициализация по умолчанию
        _characterContext.SetStrategy(new Attack1Strategy(characterAnimator));
        

        attack1Button.onClick.AddListener(() => {
            _characterContext.SetStrategy(new Attack1Strategy(characterAnimator));
        });

        attack2Button.onClick.AddListener(() => {
            _characterContext.SetStrategy(new Attack2Strategy(characterAnimator));
        });

        attack3Button.onClick.AddListener(() => {
            _characterContext.SetStrategy(new Attack3Strategy(characterAnimator));
        });
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q) && _characterContext != null)
        {
            _characterContext.PerformAttack();

        }
    }

}

