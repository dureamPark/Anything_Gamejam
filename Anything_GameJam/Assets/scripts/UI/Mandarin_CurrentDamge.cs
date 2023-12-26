using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Mandarin_CurrentDamage : MonoBehaviour
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
        myText.text = "±Ö °ø°Ý·Â : " + AM.Mandarin_Damage.ToString();
    }
}
