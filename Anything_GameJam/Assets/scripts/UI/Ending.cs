using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ending : MonoBehaviour
{
    public Animator animator;

    void Start()
    {
        // 애니메이터 컴포넌트를 찾아 할당합니다.
        animator = GetComponent<Animator>();
        if (animator == null)
        {
            Debug.LogError("Animator component not found!");
        }
    }

    void Update()
    {
        // 게임 엔딩을 트리거하는 조건을 설정합니다.
        if (Input.GetKeyDown(KeyCode.E))
        {
            TriggerEndingAnimation();
        }
    }

    void TriggerEndingAnimation()
    {
        // "EndingAnimationTrigger"는 애니메이션 컨트롤러에서 설정한 트리거 이름입니다.
        animator.SetTrigger("EndingAnimationTrigger");
    }
}

