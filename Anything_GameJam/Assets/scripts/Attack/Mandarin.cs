using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mandarin : MonoBehaviour
{
    public float speed;

    private void FixedUpdate()
    {
        transform.Translate(speed * -0.01f, 0, 0);

        // ȭ�� ������ ������ ������Ʈ�� �Ҹ��Ų��
        if (transform.position.x < -10.0f)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {

            Destroy(gameObject);
        }
    }
}
