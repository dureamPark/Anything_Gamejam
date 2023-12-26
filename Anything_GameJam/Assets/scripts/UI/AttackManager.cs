using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackManager : MonoBehaviour
{
    public static AttackManager Instance;

<<<<<<< Updated upstream
    public GameManager GM;

=======

    public GameManager GM;



>>>>>>> Stashed changes

    public int Mandarin_Damage;
    public int Dekopon_Damage;
    public int Silver_cutlassfish_damage;
    public int Dolhareubang_damage;
    public float Mandarin_Cooltime;
    public float Dekopon_CoolTime;
    public float Dolhareubang_CoolTime;
    public float Silver_cutlassfish_CoolTime;
    public bool Mandarin_Active;
    public bool Dekopon_Active;
    public bool Dolhareubang_Active;
    public bool Silver_cutlassfish_Active;


    void Start()
    {
        Mandarin_Damage = 10;
        Dekopon_Damage = 30;
        Silver_cutlassfish_damage = 80;
        Dolhareubang_damage = 20;
        Mandarin_Active = true;
        Dekopon_Active = true;
        Dolhareubang_Active = true;
        Silver_cutlassfish_Active = true;

        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

<<<<<<< Updated upstream
    
    void Update()
    {
        if(Mandarin_Cooltime >= 0)
=======

    void Update()
    {
        if (Mandarin_Cooltime >= 0)

>>>>>>> Stashed changes
        {
            Mandarin_Cooltime -= Time.deltaTime;
        }

<<<<<<< Updated upstream
        if(Dekopon_CoolTime >= 0)
        {
            Dekopon_CoolTime -= Time.deltaTime;
        }
        if(Silver_cutlassfish_CoolTime >= 0)
        {
            Silver_cutlassfish_CoolTime -= Time.deltaTime;
        }
        if(Dolhareubang_CoolTime >= 0)
=======

        if (Dekopon_CoolTime >= 0)
        {
            Dekopon_CoolTime -= Time.deltaTime;
        }
        if (Silver_cutlassfish_CoolTime >= 0)
        {
            Silver_cutlassfish_CoolTime -= Time.deltaTime;
        }
        if (Dolhareubang_CoolTime >= 0)

            if (Dekopon_CoolTime >= 0)
            {
                Dekopon_CoolTime -= Time.deltaTime;
            }
        if (Silver_cutlassfish_CoolTime >= 0)
        {
            Silver_cutlassfish_CoolTime -= Time.deltaTime;
        }
        if (Dolhareubang_CoolTime >= 0)

>>>>>>> Stashed changes
        {
            Dolhareubang_CoolTime -= Time.deltaTime;
        }

        if (!Mandarin_Active)
        {
            if (Mandarin_Cooltime <= 0)
            {
                Mandarin_Active = true;
            }
        }


        if (!Dekopon_Active)
        {
<<<<<<< Updated upstream
            if(Dekopon_CoolTime <= 0)
            {
                Dekopon_Active = true;
            }
=======

            if (Dekopon_CoolTime <= 0)

                if (Dekopon_CoolTime <= 0)

                {
                    Dekopon_Active = true;
                }
>>>>>>> Stashed changes
        }

        if (!Silver_cutlassfish_Active)
        {
            if (Silver_cutlassfish_CoolTime <= 0)
            {
                Silver_cutlassfish_Active = true;
            }
        }

        if (!Dolhareubang_Active)
        {
            if (Dolhareubang_CoolTime <= 0)
            {
                Dolhareubang_Active = true;
            }
        }
    }
   
    public void Mandarin_Attack()
    {
        if (Mandarin_Active)
        {
<<<<<<< Updated upstream
            Debug.Log("��");
=======

            Debug.Log("��");


>>>>>>> Stashed changes
            Mandarin_Cooltime = 0.3f;
            Mandarin_Active = false;
        }
        //�� ������
    }

    public void Dekopon_Attack()
    {
        if (Dekopon_Active)
        {
<<<<<<< Updated upstream
            GM.Money -= 5;
            Debug.Log("�Ѷ��");
=======

            GM.Money -= 5;
            Debug.Log("�Ѷ��");


>>>>>>> Stashed changes
            Dekopon_CoolTime = 2.0f;
            Dekopon_Active = false;
        }
        // �Ѷ�� ������
    }

    public void Silver_Cutlassfish_Attack()
    {
        if (Silver_cutlassfish_Active)
        {
<<<<<<< Updated upstream
            Debug.Log("����ġ");
            GM.Money -= 50;
=======

            Debug.Log("����ġ");
            GM.Money -= 50;


>>>>>>> Stashed changes
            Silver_cutlassfish_CoolTime = 5.0f;
            Silver_cutlassfish_Active = false;
        }

    }

    public void Dolhareubang_Skill()
    {
        if (Dolhareubang_Active)
        {
<<<<<<< Updated upstream
            Debug.Log("���ϸ���");
            GM.Money -= 30;
=======

            Debug.Log("���ϸ���");
            GM.Money -= 30;


>>>>>>> Stashed changes
            Dolhareubang_CoolTime = 10.0f;
            Dolhareubang_Active = false;
        }
        // ���ϸ��� ��ų
    }
}
