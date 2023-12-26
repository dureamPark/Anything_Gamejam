using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class upgradeweapon : MonoBehaviour
{
    public void madarin_updrade()
    {
        Debug.Log("귤 업그레이드");
        madarin_damage += 1;
    }
    public void dekopon_upgrade()
    {
        Debug.Log("한라봉 업그레이드");
        dekopon_damage += 1;
    }
    public void dolhareubang_upgrade()
    {
        Debug.Log("돌하르방 업그레이드");
        dolhareubang_damage += 1;
    }
    public void sliverfish_upgrade()
    {
        Debug.Log("은갈치 업그레이드");
        s_damage += 1;
    }
}
