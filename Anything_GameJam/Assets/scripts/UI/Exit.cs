using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{
    void Update()
    {
        // ���� 'ESC' Ű�� ������
        if (Input.anyKey)
        {
            // ���� ����
            Application.Quit();
        }
    }
}