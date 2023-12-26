using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShuckHB : MonoBehaviour
{
    public bool isAttacking = false; // ���� �� ���θ� Ȯ���ϴ� ����
    float targetX = -5f; // ��ǥ x ��ġ
    float speed = 5f; // �̵� �ӵ�
    int attackcount = 5;

    void Start()
    {
        // ������ �����ϸ� ���� ��ġ�� �̵�
        MoveToPosition(targetX);
    }

    void Update()
    {
        if(attackcount == 0)
        {
            Debug.Log("������ �۵��Ϸ�");
            isAttacking = false;
            gameObject.SetActive(false);
            attackcount = 5;
        }

        // ���� ���� ���� �̵��ϵ��� ó��
        if (isAttacking)
        {
            // ��ǥ ��ġ�� �������� �� �ݴ� �������� �̵�
            if (Mathf.Abs(transform.position.x - targetX) < 0.1f)
            {
                targetX = (targetX == -5f) ? 5f : -5f; // �ݴ� �������� ����
                attackcount--;
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
