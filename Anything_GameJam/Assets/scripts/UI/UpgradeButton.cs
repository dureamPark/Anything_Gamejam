using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeButton : MonoBehaviour
{
    public Button bt1, bt2, bt3, bt4;
    public GameManager GM;
    public AttackManager AM;
    //public int M;
    //public int Dek;
    //public int Dol;
    //public int Sil;
    //public int Coin;
    void Start()
    {
        GM = FindObjectOfType<GameManager>();
        AM = FindObjectOfType<AttackManager>();
        //int M = GameObject.Find("AttackManager").GetComponent<AttackManager>().Mandarin_Damage;
        //int Dek = GameObject.Find("AttackManager").GetComponent<AttackManager>().Dekopon_Damage;
        //int Dol = GameObject.Find("AttackManager").GetComponent<AttackManager>().Dolhareubang_damage;
        //int Sil = GameObject.Find("AttackManager").GetComponent<AttackManager>().Silver_cutlassfish_damage;
        //int Coin = GameObject.Find("GameManager").GetComponent<GameManager>().Money;
        bt1.onClick.AddListener(bt1up);
        bt2.onClick.AddListener(bt2up);
        bt3.onClick.AddListener(bt3up);
        bt4.onClick.AddListener(bt4up);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void bt1up()
    {
        if (GM.Money <= 99)
        {
            Debug.Log("���� �����մϴ�");
        }
        else
        {
            Debug.Log("�� ���׷��̵�");
            AM.Mandarin_Damage += 1;
            GM.Money -= 100;
            Debug.Log("�� : " + AM.Mandarin_Damage);
            Debug.Log("��: " + GM.Money);
        }
        
    }
    void bt2up()
    {
        if (GM.Money <= 199)
        {
            Debug.Log("���� �����մϴ�");
        }
        else
        {
            Debug.Log("�Ѷ�� ���׷��̵�");
            AM.Dekopon_Damage += 1;
            GM.Money -= 200;
            Debug.Log("�Ѷ�� : " + AM.Dekopon_Damage);
            Debug.Log("��: " + GM.Money);
        }
        
    }
    void bt3up()
    {
        if (GM.Money <= 299)
        {
            Debug.Log("���� �����մϴ�");
        }
        else
        {
            Debug.Log("���ϸ��� ���׷��̵�");
            GM.Money -= 300;
            AM.Dolhareubang_damage += 1;
            Debug.Log("���ϸ��� : " + AM.Dolhareubang_damage);
            Debug.Log("��: " + GM.Money);
        }
        
    }
    void bt4up()
    {
        if (GM.Money <= 499)
        {
            Debug.Log("���� �����մϴ�");
        }
        else
        {
            Debug.Log("����ġ ���׷��̵�");
            AM.Silver_cutlassfish_damage += 1;
            GM.Money -= 500;
            Debug.Log("����ġ : " + AM.Silver_cutlassfish_damage);
            Debug.Log("��: " + GM.Money);
        }
        
    }
}
