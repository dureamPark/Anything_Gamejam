using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShuckHB : MonoBehaviour
{
    bool isAttacking = true; // 공격 중 여부를 확인하는 변수
    float targetX = -5f; // 목표 x 위치
    float speed = 5f; // 이동 속도

    void Start()
    {
        // 공격을 시작하면 시작 위치로 이동
        MoveToPosition(targetX);
    }

    void Update()
    {
        // 공격 중일 때만 이동하도록 처리
        if (isAttacking)
        {
            // 목표 위치에 도착했을 때 반대 방향으로 이동
            if (Mathf.Abs(transform.position.x - targetX) < 0.1f)
            {
                targetX = (targetX == -5f) ? 5f : -5f; // 반대 방향으로 변경
            }

            // 계속해서 목표 위치로 이동
            MoveToPosition(targetX);
        }
    }

    // 목표 위치로 이동하는 함수
    void MoveToPosition(float targetX)
    {
        float step = speed * Time.deltaTime; // 이동 속도
        Vector3 targetPosition = new Vector3(targetX, transform.position.y, transform.position.z);
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, step);
    }
}
