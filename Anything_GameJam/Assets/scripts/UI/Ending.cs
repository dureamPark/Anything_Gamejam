using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ending : MonoBehaviour
{
    public Animator animator;

    void Start()
    {
        // �ִϸ����� ������Ʈ�� ã�� �Ҵ��մϴ�.
        animator = GetComponent<Animator>();
        if (animator == null)
        {
            Debug.LogError("Animator component not found!");
        }
    }

    void Update()
    {
        // ���� ������ Ʈ�����ϴ� ������ �����մϴ�.
        if (Input.GetKeyDown(KeyCode.E))
        {
            TriggerEndingAnimation();
        }
    }

    void TriggerEndingAnimation()
    {
        // "EndingAnimationTrigger"�� �ִϸ��̼� ��Ʈ�ѷ����� ������ Ʈ���� �̸��Դϴ�.
        animator.SetTrigger("EndingAnimationTrigger");
    }
}

