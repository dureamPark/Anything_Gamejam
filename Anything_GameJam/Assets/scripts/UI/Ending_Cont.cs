using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ending_Cont : MonoBehaviour
{
    public float animationDuration = 2.0f;
    public GameObject game;
    void Start()
    {
        // 애니메이션을 시작할 때 즉시 호출
        StartEndingAnimation();
    }

    void StartEndingAnimation()
    {
        // 화면 아래에서 위로 이동하는 Tween 애니메이션 등을 사용하여 엔딩 애니메이션 디자인
        LeanTween.moveY(game, Screen.height / 2f, animationDuration)
            .setEaseInOutQuad()
            .setOnComplete(() =>
            {
                // 애니메이션이 종료되면 할 일
                Debug.Log("Ending animation completed!");
            });
    }
}

