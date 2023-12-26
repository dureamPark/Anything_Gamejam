using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Dekopon_CurrentDamage : MonoBehaviour
{
    TextMeshProUGUI myText;
    public AttackManager AM;
    // Start is called before the first frame update
    void Start()
    {
        AM = FindObjectOfType<AttackManager>();
        myText = GetComponent<TextMeshProUGUI>();

    }

    // Update is called once per frame
    void Update()
    {
        myText.text = "한라봉 공격력 : " + AM.Dekopon_Damage.ToString();
    }
}

