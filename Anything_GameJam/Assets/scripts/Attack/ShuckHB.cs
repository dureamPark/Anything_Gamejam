using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShuckHB : MonoBehaviour
{
    bool isAttacking = true; // ���� �� ���θ� Ȯ���ϴ� ����
    float targetX = -5f; // ��ǥ x ��ġ
    float speed = 5f; // �̵� �ӵ�

    void Start()
    {
        // ������ �����ϸ� ���� ��ġ�� �̵�
        MoveToPosition(targetX);
    }

    void Update()
    {
        // ���� ���� ���� �̵��ϵ��� ó��
        if (isAttacking)
        {
            // ��ǥ ��ġ�� �������� �� �ݴ� �������� �̵�
            if (Mathf.Abs(transform.position.x - targetX) < 0.1f)
            {
                targetX = (targetX == -5f) ? 5f : -5f; // �ݴ� �������� ����
            }

            // ����ؼ� ��ǥ ��ġ�� �̵�
            MoveToPosition(targetX);
        }
    }

    // ��ǥ ��ġ�� �̵��ϴ� �Լ�
    void MoveToPosition(float targetX)
    {
        float step = speed * Time.deltaTime; // �̵� �ӵ�
        Vector3 targetPosition = new Vector3(targetX, transform.position.y, transform.position.z);
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, step);
    }
}
