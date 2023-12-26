using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackManager : MonoBehaviour
{
    public static AttackManager Instance;


    public GameManager GM;
    public UpgradeWeapon UW;

    public GameObject Mandarin;
    public GameObject Dekopon;
    public GameObject Dolharbang;
    public GameObject Silver_culassfish;
    public GameObject shushucki;
    public GameObject moai;

    public Audio_play M_A;
    public Audio_play D_A;
    public Audio_play S_A;
    public Audio_play DH_A;
    public Audio_play SH_A;

    public GameObject Skill5;
    public GameObject Skill6;

    public Harbang harbang;
    public ShuckHB shuck;
    public Moai MI;



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



    //히든 스킬
    public int Sibalroma_Damage;
    public float Sibalroma_CoolTime;
    public bool Sibalroma_Active;

    public int Moai_Damage;
    public float Moai_CoolTime;
    public bool Moai_Active;

    void Start()
    {
        Skill5.SetActive(false);
        Skill6.SetActive(false);
        Mandarin_Damage = 1;
        Dekopon_Damage = 30;
        Silver_cutlassfish_damage = 80;
        Dolhareubang_damage = 20;
        Sibalroma_Damage = 80;
        Moai_Damage = 80;
        Mandarin_Active = true;
        Dekopon_Active = true;
        Dolhareubang_Active = true;
        Silver_cutlassfish_Active = true;
        Sibalroma_Active = true;
        Moai_Active = true;
        UW = FindObjectOfType<UpgradeWeapon>();
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
        if (UW.Skill5_Unlock)
        {
            Skill5.SetActive(true);
        }

        if (UW.Skill6_Unlock)
        {
            Skill6.SetActive(true);
        }

        if (Mandarin_Cooltime >= 0)
        {
            Mandarin_Cooltime -= Time.deltaTime;
        }


        if (Dekopon_CoolTime >= 0)
        {
            Dekopon_CoolTime -= Time.deltaTime;
        }

        if (Silver_cutlassfish_CoolTime >= 0)
        {
            Silver_cutlassfish_CoolTime -= Time.deltaTime;
        }

        if (Dekopon_CoolTime >= 0)
        {
            Dekopon_CoolTime -= Time.deltaTime;
        }

        if (Silver_cutlassfish_CoolTime >= 0)
        {
            Silver_cutlassfish_CoolTime -= Time.deltaTime;
        }

        if (Dolhareubang_CoolTime >= 0)
        {
            Dolhareubang_CoolTime -= Time.deltaTime;
        }

        if (Sibalroma_CoolTime >= 0)
        {
            Sibalroma_CoolTime -= Time.deltaTime;
        }

        if (Moai_CoolTime >= 0)
        {
            Moai_CoolTime -= Time.deltaTime;
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
            if (Dekopon_CoolTime <= 0)
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

        if (!Sibalroma_Active)
        {
            if (Sibalroma_CoolTime <= 0)
            {
                Sibalroma_Active = true;
            }
        }

        if (!Moai_Active)
        {
            if (Moai_CoolTime <= 0)
            {
                Moai_Active = true;
            }
        }

    }
    public void Mandarin_Attack()
    {
        if (Mandarin_Active)
        {

            Debug.Log("귤");

            M_A.Au_Play();
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

            D_A.Au_Play();
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

            S_A.Au_Play();
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

            Invoke("Harbang_Audio_play", 6.5f);
            Dolhareubang_CoolTime = 45.0f;
            harbang.isRising = true;
            Dolharbang.SetActive(true);
            Dolhareubang_Active = false;
            Invoke("Harbang_Deactive", 30.0f);
        }
        // 돌하르방 스킬
    }

    public void Harbang_Deactive()
    {
        Dolharbang.SetActive(false);
    }

    public void Harbang_Audio_play()
    {
        DH_A.Au_Play();
    }

    public void Sibalroma_skill()
    {
        if (UW.Skill5_Unlock)
        {
            if (Sibalroma_Active)
            {
                Debug.Log("슉슈슉");

                Sibalroma_CoolTime = 50.0f;
                shuck.isAttacking = true;
                shushucki.SetActive(true);
                Sibalroma_Active = false;
                Shuck_Audio_play();
            }
        }
    }

    public void Shuck_Audio_play()
    {
        SH_A.Au_Play();
    }

    public void Mirandao_Moai_Skill()
    {
        if(UW.Skill6_Unlock)
        {
            if (Moai_Active)
            {
                Debug.Log("귤모아이");
                Moai_CoolTime = 50.0f;
                moai.SetActive(true);
                MI.isDown = true;
                Moai_Active = false;
                Invoke("Moai_Deactive", 7.0f);
            }
        }
    }

    public void Moai_Deactive()
    {
        moai.SetActive(false);
    }
}
