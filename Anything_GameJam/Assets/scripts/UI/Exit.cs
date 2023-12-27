using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{
    void Update()
    {
        // 만약 'ESC' 키를 누르면
        if (Input.anyKey)
        {
            // 게임 종료
            Application.Quit();
        }
    }
}
