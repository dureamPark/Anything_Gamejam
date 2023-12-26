using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeButton : MonoBehaviour
{
    public Button bt1, bt2, bt3, bt4;
    public int M;
    public int Dek;
    public int Dol;
    public int Sil;
    public int Coin;
    void Start()
    {
        int M = GameObject.Find("AttackManager").GetComponent<AttackManager>().Mandarin_Damage;
        int Dek = GameObject.Find("AttackManager").GetComponent<AttackManager>().Dekopon_Damage;
        int Dol = GameObject.Find("AttackManager").GetComponent<AttackManager>().Dolhareubang_damage;
        int Sil = GameObject.Find("AttackManager").GetComponent<AttackManager>().Silver_cutlassfish_damage;
        int Coin = GameObject.Find("GameManager").GetComponent<GameManager>().Money;
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
        if (Coin <= 0)
        {
            Debug.Log("돈이 부족합니다");
        }
        else
        {
            Debug.Log("귤 업그레이드");
            M += 1;
            Coin -= 100;
            Debug.Log("귤 : " + M);
            Debug.Log("돈: " + Coin);
        }
        
    }
    void bt2up()
    {
        if (Coin <= 0)
        {
            Debug.Log("돈이 부족합니다");
        }
        else
        {
            Debug.Log("한라봉 업그레이드");
            Dek += 1;
            Coin -= 200;
            Debug.Log("한라봉 : " + Dek);
            Debug.Log("돈: " + Coin);
        }
        
    }
    void bt3up()
    {
        if (Coin <= 0)
        {
            Debug.Log("돈이 부족합니다");
        }
        else
        {
            Debug.Log("돌하르방 업그레이드");
            Dol += 1;
            Coin -= 300;
            Debug.Log("돌하르방 : " + Dol);
            Debug.Log("돈: " + Coin);
        }
        
    }
    void bt4up()
    {
        if (Coin <= 0)
        {
            Debug.Log("돈이 부족합니다");
        }
        else
        {
            Debug.Log("은갈치 업그레이드");
        Sil += 1;
        Coin -= 500;
        Debug.Log("은갈치 : " + Sil);
        Debug.Log("돈: " + Coin);
        }
        
    }
}
