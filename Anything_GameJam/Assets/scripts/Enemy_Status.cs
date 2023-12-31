using System.Collections;
using UnityEngine;

public class Enemy_Status : MonoBehaviour
{
    public GameManager GM;
    public AttackManager AM;
    private AudioSource AU;
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
    public int Drop_Money;

    private void Start()
    {
        AU = GetComponent<AudioSource>();
        AM = FindObjectOfType<AttackManager>();
        GM = FindObjectOfType<GameManager>();
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
        GM.Player_HP -= E_AD;
        AU.Play();
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
            GM.Money += Drop_Money;
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
            Debug.Log("�ֿ� �´�");
            animator_effect.SetTrigger("isOr");
            isDamaged = true;
            DAMAGE(AM.Mandarin_Damage);
        }
        if (collision.gameObject.tag == "Hanra")
        {
            animator_effect.SetTrigger("isHa");
            isDamaged = true;
            DAMAGE(AM.Dekopon_Damage);
        }
        if (collision.gameObject.tag == "Silver")
        {
            animator_effect.SetTrigger("isGa");
            isDamaged = true;
            DAMAGE(AM.Silver_cutlassfish_damage);
        }

        if (collision.gameObject.tag == "Dol")
        {
            if (!Slow)
            {
                Slow = true;
                StartCoroutine(SLOW());
            }
        }

        if(collision.gameObject.tag == "shuckHB")
        {
            isDamaged = true;
            DAMAGE(AM.Sibalroma_Damage);
        }

        if(collision.gameObject.tag == "moai")
        {
            isDamaged = true;
            DAMAGE(AM.Moai_Damage);
        }
    }
}
