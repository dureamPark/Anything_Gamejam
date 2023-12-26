using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveManager : MonoBehaviour
{
    public static WaveManager Instance;
    public GameManager GM;
    public bool Waving;
    public int Enemy_Num;
    public int EnemyA_N;
    public int EnemyB_N;
    public int EnemyC_N;

    void Start()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }

        Waving = false;
    }

    
    void Update()
    {
        if (!Waving)
        {
            WaveStart();
        }
        if (Enemy_Num <= 0)
        {
            WaveEnd();
        }
    }

    public void WaveStart()
    {
        Waving = true;
        EnemyGenerate();
    }

    public void WaveEnd()
    {
        Waving = false;
        GM.Money += 500 * GM.Wave;
        GM.Wave++;
    }
    public void EnemyGenerate()
    {
        if(GM.Wave == 1)
        {
            Enemy_Num = 3;
            EnemyA_N = 1;
            EnemyB_N = 1;
            EnemyC_N = 1;
        }else if(GM.Wave == 2)
        {
            Enemy_Num = 3;
            EnemyA_N = 1;
            EnemyB_N = 1;
            EnemyC_N = 1;
        }
        else if(GM.Wave == 3)
        {
            Enemy_Num = 3;
            EnemyA_N = 1;
            EnemyB_N = 1;
            EnemyC_N = 1;
        }
        else if(GM.Wave == 4)
        {
            Enemy_Num = 3;
            EnemyA_N = 1;
            EnemyB_N = 1;
            EnemyC_N = 1;
        }
        else if(GM.Wave == 5)
        {
            Enemy_Num = 3;
            EnemyA_N = 1;
            EnemyB_N = 1;
            EnemyC_N = 1;
        }
        else if(GM.Wave == 6)
        {
            Enemy_Num = 3;
            EnemyA_N = 1;
            EnemyB_N = 1;
            EnemyC_N = 1;
        }
        else if(GM.Wave == 7)
        {
            Enemy_Num = 3;
            EnemyA_N = 1;
            EnemyB_N = 1;
            EnemyC_N = 1;
        }
        else if(GM.Wave == 8)
        {
            Enemy_Num = 3;
            EnemyA_N = 1;
            EnemyB_N = 1;
            EnemyC_N = 1;
        }
        else if(GM.Wave == 9)
        {
            Enemy_Num = 3;
            EnemyA_N = 1;
            EnemyB_N = 1;
            EnemyC_N = 1;
        }
        else if(GM.Wave == 10)
        {
            Enemy_Num = 3;
            EnemyA_N = 1;
            EnemyB_N = 1;
            EnemyC_N = 1;
        }
    }
}
