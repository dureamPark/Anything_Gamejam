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

    private void Start()
    {
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
        Debug.Log("�� ���׷��̵�");
        if(GM.Money >= 200)
        {
            GM.Money -= 200;
            AM.Mandarin_Damage += 1;
            Mandarin_Upgrade_count++;
        }
    }
    public void dekopon_upgrade()
    {
        Debug.Log("�Ѷ�� ���׷��̵�");
        if (GM.Money >= 300)
        {
            GM.Money -= 300;
            AM.Dekopon_Damage += 3;
            Dekopon_Upgrade_count++;
        }
    }
    public void dolhareubang_upgrade()
    {
        Debug.Log("���ϸ���(Ư����ų �ر�) ���׷��̵�");
        if(Harbang_Upgrade_count <= 2)
        {
            if (GM.Money >= 5000)
            {
                GM.Money -= 5000;
                Harbang_Upgrade_count++;
            }
        }
    }
    public void sliverfish_upgrade()
    {
        Debug.Log("����ġ ���׷��̵�");
        if (GM.Money >= 1000)
        {
            GM.Money -= 1000;
            AM.Silver_cutlassfish_damage += 10;
            Silver_Upgrade_count++;
        }
    }
}
