using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeWeapon : MonoBehaviour
{
    public static UpgradeWeapon Instance;
    public AttackManager AM;

    public void Madarin_Updrade()
    {
        Debug.Log("�� ���׷��̵�");
        AM.Mandarin_Damage += 1;
    }
    public void dekopon_upgrade()
    {
        Debug.Log("�Ѷ�� ���׷��̵�");
        AM.Dekopon_Damage += 1;
    }
    public void dolhareubang_upgrade()
    {
        Debug.Log("���ϸ��� ���׷��̵�");
        AM.Dolhareubang_damage += 1;
    }
    public void sliverfish_upgrade()
    {
        Debug.Log("����ġ ���׷��̵�");
        AM.Silver_cutlassfish_damage += 1;
    }
}
