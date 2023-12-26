using System.Collections;
using UnityEngine;

public class Enemy_Status : MonoBehaviour
{
    private WaveManager waveManager;
    private Rigidbody2D rb;
    private Animator animator;
    GameObject effect;
    Animator animator_effect;

    [SerializeField] private int E_HP;
    [SerializeField] private int E_AD;
    [SerializeField] private float E_Speed;
    [SerializeField] private float attackCooldown;

    private bool isDamaged = false;
    private bool Slow = false;
    private bool Stop = false;
    private bool CanAttack = false;
    private float attackTimer = 0f; 

    private void Start()
    {
        effect = transform.GetChild(0).gameObject;
        animator_effect = effect.GetComponent<Animator>();
        animator = gameObject.GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        DIE();
        AnimationUpdate();
        if (!Stop)
        {
            MOVE();
        }
        else
        {
            E_Speed = 0f;
            if (CanAttack)
            {
                AttackControl();
            }
        }

        if (attackTimer > 0)
        {
            attackTimer -= Time.deltaTime;
        }
    }

    void AnimationUpdate()
    {
        if (Stop)
        {
            animator.SetBool("isWalk", false);
            animator.SetBool("isAttack", true);
        }
        else
        {
            animator.SetBool("isAttack", false);
            animator.SetBool("isWalk", true);
        }
    }
    private void MOVE()
    {
        Vector3 moveDirection = Vector3.right * E_Speed * Time.deltaTime;
        transform.position += moveDirection;
    }

    private IEnumerator SLOW()
    {
        E_Speed *= 0.5f;
        yield return new WaitForSeconds(3f);
        E_Speed *= 2f;
        Slow = false;
    }

    private void AttackControl()
    {
        if (attackTimer <= 0)
        {
            ATTACK();
            attackTimer = attackCooldown;
        }
    }

    private void ATTACK()
    {
        Debug.Log("Attacking");
    }

    private void DAMAGE(int HitDamaged)
    {
        if (isDamaged)
        {
            E_HP -= HitDamaged;
            isDamaged = false;
        }
    }

    private void DIE()
    {
        if (E_HP <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            Stop = true;
            CanAttack = true;
        }

        if (collision.gameObject.tag == "Mandarin")
        {
            Debug.Log("±Ö¿¡ ¸Â´Ù");
            animator_effect.SetTrigger("isOr");
            isDamaged = true;
            DAMAGE(1);
        }
        if (collision.gameObject.tag == "Hanra")
        {
            animator_effect.SetTrigger("isHa");
            isDamaged = true;
            DAMAGE(2);
        }
        if (collision.gameObject.tag == "Silver")
        {
            animator_effect.SetTrigger("isGa");
            isDamaged = true;
            DAMAGE(3);
        }

        if (collision.gameObject.tag == "Dol")
        {
            if (!Slow)
            {
                Slow = true;
                StartCoroutine(SLOW());
            }
        }
    }
}
