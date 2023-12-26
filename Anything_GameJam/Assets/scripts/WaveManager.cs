using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveManager : MonoBehaviour
{
    public static WaveManager Instance;
    public GameManager GM;
    public bool Waving;

    public float Wave_Cooltime;
    public float Wave_time = 40;

    void Start()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this.gameObject);
            return;
        }

        Waving = false;
    }

    
    void Update()
    {
        // ���̺� ����
        if(Wave_Cooltime <= 0 && !Waving)
        {
            WaveStart();
        }

        // ���̺� ��
        if(Waving)
        {
            Wave_time -= Time.deltaTime;
        }

        // ���̺� ��
        if(Waving && Wave_time <= 0) 
        {
            WaveEnd();
        }

        // ��� ����
        if(!Waving && Wave_Cooltime > 0)
        {
            Wave_Cooltime -= Time.deltaTime;
        }
    }

    public void WaveStart()
    {
        Waving = true;
        Wave_time = 40;
    }

    public void WaveEnd()
    {
        Waving = false;
        Wave_Cooltime = 5;
        GM.Money += 500 * GM.Wave;
        GM.Wave++;
    }
    
}
