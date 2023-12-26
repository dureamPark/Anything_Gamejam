using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ending_go : MonoBehaviour
{
    public GameManager gm;

    private void Start()
    {
      
        
    }
    void Update()
    {
        if (gm.Player_HP <= 0)
        {
            TransitionToSadScene();
        }
        else
        {
            TransitionToHappyScene();
        }
    }

    void TransitionToHappyScene()
    {

        SceneManager.LoadScene("HappyEnding");

    }

    void TransitionToSadScene()
    {

        SceneManager.LoadScene("SadEnding");

    }
}
