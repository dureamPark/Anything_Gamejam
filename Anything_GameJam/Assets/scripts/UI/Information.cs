using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Information : MonoBehaviour
{
    void Update()
    {
        if (Input.anyKey)
        {
            TransitionToNextScene();
        }
    }

    void TransitionToNextScene()
    {

        SceneManager.LoadScene("attack_test 1");

    }
}
