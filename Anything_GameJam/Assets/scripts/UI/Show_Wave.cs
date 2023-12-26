using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Show_Wave : MonoBehaviour
{
    public GameManager GM;

    TextMeshProUGUI myText;

    void Start()
    {
        GM = FindObjectOfType<GameManager>();
        myText = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        myText.text = "WAVE : " + GM.Wave.ToString();
    }
}
