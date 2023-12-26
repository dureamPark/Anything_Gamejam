using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WaveManager : MonoBehaviour
{
    public static WaveManager Instance;
    public GameManager GM;
    public GameObject Josuk;
    public GameObject player_space;
    public floor FL;
    public bool Waving;

    public Audio_play mil;
    public Audio_play Ssul;

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
        // 웨이브 시작
        if(Wave_Cooltime <= 0 && !Waving)
        {
            WaveStart();
        }

        // 웨이브 중
        if(Waving)
        {
            Wave_time -= Time.deltaTime;
            if (GM.Player_HP <= 0)
            {
                TransitionToSadScene();
            }
        }

        // 웨이브 끝
        if(Waving && Wave_time <= 0) 
        {
            WaveEnd();
        }

        // 대기 시작
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
        Josuck_Start();
        Invoke("Josuck_End", 3.6f);
        
        TransitionToHappyScene();
    }

    void TransitionToHappyScene()
    {

        SceneManager.LoadScene("HappyEnding");

    }

    void TransitionToSadScene()
    {

        SceneManager.LoadScene("SadEnding");

    }

    public void Josuck_Start()
    {
        FL.Start_josuck();
        Josuk.SetActive(true);
        mil.Au_Play();
        Vector3 newPosition = player_space.transform.position + new Vector3(0 , 0.25f , 0);
        player_space.transform.position = newPosition;

    }

    public void Josuck_End()
    {
        FL.End_josuck();
        Josuk.SetActive(false);
        Ssul.Au_Play();
        Vector3 originalPosition = new Vector3(5.9f, -0.25f, 0);
        player_space.transform.position = originalPosition;
    }
    
}
