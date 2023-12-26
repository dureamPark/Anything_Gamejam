using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveManager : MonoBehaviour
{
    public static WaveManager Instance;
    public GameManager GM;
    public bool Waving;

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
        if (!Waving)
        {

            WaveStart();
        }
    }

    public void WaveStart()
    {
        Waving = true;
    }

    public void WaveEnd()
    {
        Waving = false;
        GM.Money += 500 * GM.Wave;
        GM.Wave++;
    }
    
}
