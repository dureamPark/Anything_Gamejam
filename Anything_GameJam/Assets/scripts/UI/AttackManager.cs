using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackManager : MonoBehaviour
{
    public static AttackManager Instance;

    public GameManager GM;

    public GameObject Mandarin;
    public GameObject Dekopon;
    public GameObject Dolharbang;
    public GameObject Silver_culassfish;


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
    public static bool Dolhareubang_Active;
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

    
    void Update()
    {
        if(Mandarin_Cooltime >= 0)
        {
            Mandarin_Cooltime -= Time.deltaTime;
        }

        if(Dekopon_CoolTime >= 0)
        {
            Dekopon_CoolTime -= Time.deltaTime;
        }
        if(Silver_cutlassfish_CoolTime >= 0)
        {
            Silver_cutlassfish_CoolTime -= Time.deltaTime;
        }
        if(Dolhareubang_CoolTime >= 0)
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
            if(Dekopon_CoolTime <= 0)
            {
                Dekopon_Active = true;
            }
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
            Debug.Log("귤");
            Mandarin_Cooltime = 0.3f;
            Mandarin_Active = false;
            GameObject shoot_Mandarin = Instantiate(Mandarin);
            shoot_Mandarin.transform.position = new Vector3(6, -1.8f, 0);
        }
        //귤 날리기
    }

    public void Dekopon_Attack()
    {
        if (Dekopon_Active)
        {
            GM.Money -= 5;
            Debug.Log("한라봉");
            Dekopon_CoolTime = 2.0f;
            Dekopon_Active = false;
            GameObject shoot_Dekopon = Instantiate(Dekopon);
            shoot_Dekopon.transform.position = new Vector3(6, -1.8f, 0);
        }
        // 한라봉 날리기
    }

    public void Silver_Cutlassfish_Attack()
    {
        if (Silver_cutlassfish_Active)
        {
            Debug.Log("은갈치");
            GM.Money -= 50;
            Silver_cutlassfish_CoolTime = 5.0f;
            Silver_cutlassfish_Active = false;
            GameObject shoot_Silver = Instantiate(Silver_culassfish);
            shoot_Silver.transform.position = new Vector3(6, -1.8f, 0);
        }
        // 은갈치 날리기
    }

    public void Dolhareubang_Skill()
    {
        if (Dolhareubang_Active)
        {
            Debug.Log("돌하르방");
            GM.Money -= 30;
            Dolhareubang_CoolTime = 10.0f;
            Dolhareubang_Active = false;
        }
        // 돌하르방 스킬
    }
}
