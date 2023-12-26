using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Status : MonoBehaviour
{
    private Rigidbody2D rb;

    [SerializeField] int E_HP;
    [SerializeField] int E_AD;
    [SerializeField] float E_Speed;

    bool Damaged = false;
    bool Slow = false;
    bool Stop = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (!Stop)
        {
            MOVE();
        }
        else
        {
            STOP();
        }

        if (Slow)
        {
            SLOW();
        }

        DIE();
    }

    void MOVE()
    {
        Vector3 moveDirection = Vector3.right * E_Speed * Time.deltaTime;
        transform.position += moveDirection;
    }

    void SLOW()
    {
        if (Slow)
        {
            E_Speed *= 0.5f;
        }
        else
        {
            E_Speed *= 2f;
        }
    }

    void STOP()
    {
        E_Speed = 0f;
        Debug.Log("Stopped");
        ATTACK();
    }

    void ATTACK()
    {
        Debug.Log("Attacking");
    }

    void DIE()
    {
        if (E_HP <= 0)
        {
            Destroy(gameObject);
            //Wm.manger instance.monster¼ö --;
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            Debug.Log("°¨Áö");
            Stop = true;
        }
    }
}
