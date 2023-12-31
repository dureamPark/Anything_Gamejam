using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public float Player_HP;
    public float Max_Player_HP;
    public int Wave;
    public int Money;
    
    public Slider HP_Gauge;
    public Text Money_text;
    public GameObject UU;
    bool UU_Active;

    //public GameObjcet Upgrade_UI;
    //bool Upgrade_UI_Active;


    void Start()
    {
        Player_HP = 100;
        Max_Player_HP = 100;
        Wave = 1;
        Money = 2000;
        HP_Gauge.value = Player_HP / Max_Player_HP;
        UU_Active = false;

        UU.SetActive(UU_Active);

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
        

        if (Player_HP <= 0)
        {
            SceneManager.LoadScene("gameover");
        }

        if (Input.GetKeyDown(KeyCode.U))
        {
            UU_Active = !UU_Active;
            UU.SetActive(UU_Active);
        }
    }

    private void LateUpdate()
    {
        HP_Gauge.value = Player_HP / Max_Player_HP;
        Money_text.text = "Money : " + Money.ToString();

    }
}
