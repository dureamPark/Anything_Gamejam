using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public int Player_HP;
    public int Max_Player_HP;
    public int Wave;
    public int Money;

    public Slider HP_Gauge;

    //public GameObjcet Upgrade_UI;
    //bool Upgrade_UI_Active;


    void Start()
    {
        Player_HP = 100;
        Max_Player_HP = 100;
        Wave = 1;
        Money = 1000;
        HP_Gauge.value = Player_HP / Max_Player_HP;

        if (Instance == null)
        {
            DontDestroyOnLoad(this.gameObject);
            Instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    
    void Update()
    {
        if(Player_HP <= 0)
        {
            SceneManager.LoadScene("gameover");
        }

        if (Input.GetKeyDown(KeyCode.U))
        {
            //SetActive(true);
        }
    }
}
