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

        // 화면 밖으로 나오면 오브젝트를 소멸시킨다
        if (transform.position.x < -10.0f)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {

        }
    }
}
