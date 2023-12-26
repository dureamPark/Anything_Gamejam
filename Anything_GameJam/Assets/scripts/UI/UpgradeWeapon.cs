using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeWeapon : MonoBehaviour
{
    public static UpgradeWeapon Instance;
    public AttackManager AM;
    public GameManager GM;

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

    public void Madarin_Updrade()
    {
        Debug.Log("�� ���׷��̵�");
        if(GM.Money >= 200)
        {
            GM.Money -= 200;
            AM.Mandarin_Damage += 1;
        }
    }
    public void dekopon_upgrade()
    {
        Debug.Log("�Ѷ�� ���׷��̵�");
        if (GM.Money >= 300)
        {
            GM.Money -= 300;
            AM.Dekopon_Damage += 3;
        }
    }
    public void dolhareubang_upgrade()
    {
        Debug.Log("���ϸ��� ���׷��̵�");
        if (GM.Money >= 500)
        {
            GM.Money -= 500;
            AM.Dolhareubang_damage += 5;
        }
    }
    public void sliverfish_upgrade()
    {
        Debug.Log("����ġ ���׷��̵�");
        if (GM.Money >= 1000)
        {
            GM.Money -= 1000;
            AM.Silver_cutlassfish_damage += 10;
        }
    }
}
