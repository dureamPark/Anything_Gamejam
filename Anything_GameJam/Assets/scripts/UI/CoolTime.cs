using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CoolTime : MonoBehaviour
{
    public GameObject[] hideButtons;
    public GameObject[] textPros;
    public TextMeshProUGUI[] hideTimeTexts;
    public Image[] hideButtonImages;
    private float[] ButtonTimes = { 0.3f, 2.0f, 5.0f, 45.0f, 50.0f, 50.0f };
    private float[] getButtonTimes = { 0, 0, 0, 0, 0, 0 };
    private bool[] isCooldownActive = { false, false, false, false, false, false };

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < textPros.Length; i++)
        {
            hideTimeTexts[i] = textPros[i].GetComponent<TextMeshProUGUI>();
            hideButtons[i].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        HideButtonCheck();
    }

    public void HideButtonSetting(int weaponNum)
    {
        if (!isCooldownActive[weaponNum])
        {
            hideButtons[weaponNum].SetActive(true);
            getButtonTimes[weaponNum] = ButtonTimes[weaponNum];
            StartCoroutine(ButtonTimeCheck(weaponNum));
            isCooldownActive[weaponNum] = true;
        }
    }

    private void HideButtonCheck()
    {
        for (int i = 0; i < hideButtons.Length; i++)
        {
            if (getButtonTimes[i] > 0)
            {
                getButtonTimes[i] -= Time.deltaTime;

                if (getButtonTimes[i] < 0)
                {
                    getButtonTimes[i] = 0;
                    hideButtons[i].SetActive(false);
                    isCooldownActive[i] = false;
                }
                hideTimeTexts[i].text = getButtonTimes[i].ToString("00");

                float time = getButtonTimes[i] / ButtonTimes[i];
                hideButtonImages[i].fillAmount = time;
            }
        }
    }

    IEnumerator ButtonTimeCheck(int weaponNum)
    {
        while (getButtonTimes[weaponNum] > 0)
        {
            yield return null;

            //getButtonTimes[weaponNum] -= Time.deltaTime;

            if (getButtonTimes[weaponNum] < 0)
            {
                getButtonTimes[weaponNum] = 0;
                hideButtons[weaponNum].SetActive(false);
                isCooldownActive[weaponNum] = false;
            }
            hideTimeTexts[weaponNum].text = getButtonTimes[weaponNum].ToString("00");

            float time = getButtonTimes[weaponNum] / ButtonTimes[weaponNum];
            hideButtonImages[weaponNum].fillAmount = time;
        }
    }
}
