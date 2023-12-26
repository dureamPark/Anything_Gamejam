using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeWeapon : MonoBehaviour
{
    public static UpgradeWeapon Instance;
    public AttackManager AM;
    public GameManager GM;

    public bool Skill5_Unlock = false;
    public bool Skill6_Unlock = false;

    public int Mandarin_Upgrade_count = 0;
    public int Dekopon_Upgrade_count = 0;
    public int Silver_Upgrade_count = 0;
    public int Harbang_Upgrade_count = 0;

    public int Mandarin_Price = 200;
    public int Dekopon_Price = 400;
    public int Silver_Price = 1000;
    public int Harbang_Price = 3000;

    private void Start()
    {
        Mandarin_Price = 200;
        Dekopon_Price = 400;
        Silver_Price = 1000;
        Harbang_Price = 3000;
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    private void Update()
    {
        if (!Skill5_Unlock)
        {
            if (Harbang_Upgrade_count == 1)
            {
                Skill5_Unlock = true;
            }
        }

        if (!Skill6_Unlock)
        {
            if (Harbang_Upgrade_count == 2)
            {
                Skill6_Unlock = true;
            }
        }
    }

    public void Madarin_Updrade()
    {
        Debug.Log("귤 업그레이드");
        if(GM.Money >= (200 + (Mandarin_Upgrade_count * 50)))
        {
            GM.Money -= 200 + (Mandarin_Upgrade_count*50);
            AM.Mandarin_Damage += 1;
            Mandarin_Upgrade_count++;
        }
        Mandarin_Price = 200 + (Mandarin_Upgrade_count * 50);
    }
    public void dekopon_upgrade()
    {
        Debug.Log("한라봉 업그레이드");
        if (GM.Money >= (400 + (Dekopon_Upgrade_count * 50)))
        {
            GM.Money -= 400 +(Dekopon_Upgrade_count *50);
            AM.Dekopon_Damage += 5;
            Dekopon_Upgrade_count++;
        }
        Dekopon_Price = 400 + (Dekopon_Upgrade_count * 50);
    }
    public void dolhareubang_upgrade()
    {
        Debug.Log("돌하르방(특수스킬 해금) 업그레이드");
        if(Harbang_Upgrade_count < 2)
        {
            if (GM.Money >= (3000 + (Harbang_Upgrade_count * 2000)))
            {
                GM.Money -= 3000 + (Harbang_Upgrade_count * 2000);
                Harbang_Upgrade_count++;
            }
        }
        Harbang_Price = 3000 + (Harbang_Upgrade_count * 2000);
    }
    public void sliverfish_upgrade()
    {
        Debug.Log("은갈치 업그레이드");
        if (GM.Money >= (1000 + (Silver_Upgrade_count * 500)))
        {
            GM.Money -= 1000 +(Silver_Upgrade_count * 500);
            AM.Silver_cutlassfish_damage += 10;
            Silver_Upgrade_count++;
        }
        Silver_Price = 1000 + (Silver_Upgrade_count * 500);
    }
}
