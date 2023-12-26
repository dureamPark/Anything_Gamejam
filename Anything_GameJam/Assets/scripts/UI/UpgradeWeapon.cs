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
        Debug.Log("귤 업그레이드");
        GM.Money -= 100;
        AM.Mandarin_Damage += 1;
    }
    public void dekopon_upgrade()
    {
        Debug.Log("한라봉 업그레이드");
        GM.Money -= 100;
        AM.Dekopon_Damage += 1;
    }
    public void dolhareubang_upgrade()
    {
        Debug.Log("돌하르방 업그레이드");
        GM.Money -= 100;
        AM.Dolhareubang_damage += 1;
    }
    public void sliverfish_upgrade()
    {
        Debug.Log("은갈치 업그레이드");
        GM.Money -= 100;
        AM.Silver_cutlassfish_damage += 1;
    }
}
