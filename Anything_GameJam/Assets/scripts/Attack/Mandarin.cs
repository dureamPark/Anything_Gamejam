using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mandarin : MonoBehaviour
{
    public float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed, 0, 0);

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
