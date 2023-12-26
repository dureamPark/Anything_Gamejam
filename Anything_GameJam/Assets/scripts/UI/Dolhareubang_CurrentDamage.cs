using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Dolhareubang_CurrentDamage : MonoBehaviour
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
        myText.text = "돌하르방 공격력 : " + AM.Dolhareubang_damage.ToString();
    }
}