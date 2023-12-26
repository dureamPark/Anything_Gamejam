using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Show_Dekopon_Price : MonoBehaviour
{
    public UpgradeWeapon UW;

    TextMeshProUGUI myText;

    void Start()
    {
        UW = FindObjectOfType<UpgradeWeapon>();
        myText = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        myText.text = UW.Dekopon_Price.ToString();
    }
}
