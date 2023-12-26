using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ending_Cont : MonoBehaviour
{
    public float animationDuration = 2.0f;
    public GameObject game;
    void Start()
    {
        // �ִϸ��̼��� ������ �� ��� ȣ��
        StartEndingAnimation();
    }

    void StartEndingAnimation()
    {
        // ȭ�� �Ʒ����� ���� �̵��ϴ� Tween �ִϸ��̼� ���� ����Ͽ� ���� �ִϸ��̼� ������
        LeanTween.moveY(game, Screen.height / 2f, animationDuration)
            .setEaseInOutQuad()
            .setOnComplete(() =>
            {
                // �ִϸ��̼��� ����Ǹ� �� ��
                Debug.Log("Ending animation completed!");
            });
    }
}

