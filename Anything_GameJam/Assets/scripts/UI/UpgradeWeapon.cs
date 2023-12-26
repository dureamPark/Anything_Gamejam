using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeWeapon : MonoBehaviour
{
    public static UpgradeWeapon Instance;
    public AttackManager AM;

    public void Madarin_Updrade()
    {
        Debug.Log("귤 업그레이드");
        AM.Mandarin_Damage += 1;
    }
    public void dekopon_upgrade()
    {
        Debug.Log("한라봉 업그레이드");
        AM.Dekopon_Damage += 1;
    }
    public void dolhareubang_upgrade()
    {
        Debug.Log("돌하르방 업그레이드");
        AM.Dolhareubang_damage += 1;
    }
    public void sliverfish_upgrade()
    {
        Debug.Log("은갈치 업그레이드");
        AM.Silver_cutlassfish_damage += 1;
    }
}
