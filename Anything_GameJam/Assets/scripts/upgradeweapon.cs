using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class upgradeweapon : MonoBehaviour
{
    public void madarin_updrade()
    {
        Debug.Log("�� ���׷��̵�");
        madarin_damage += 1;
    }
    public void dekopon_upgrade()
    {
        Debug.Log("�Ѷ�� ���׷��̵�");
        dekopon_damage += 1;
    }
    public void dolhareubang_upgrade()
    {
        Debug.Log("���ϸ��� ���׷��̵�");
        dolhareubang_damage += 1;
    }
    public void sliverfish_upgrade()
    {
        Debug.Log("����ġ ���׷��̵�");
        s_damage += 1;
    }
}
