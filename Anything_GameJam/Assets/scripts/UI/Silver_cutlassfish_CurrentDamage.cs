using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Silver_cutlassfish_CurrentDamage : MonoBehaviour
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
        myText.text = "은갈치 공격력 : " + AM.Silver_cutlassfish_damage.ToString();
    }
}