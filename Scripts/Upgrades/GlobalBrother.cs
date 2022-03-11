using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalBrother : MonoBehaviour
{
    public GameObject fakeButton;
    public GameObject realButton;
    public GameObject priceText;
    public GameObject levelText;
    public TMPro.TMP_Text coinsText;
    public double currentCash;
    public static double brotherValue = 10;
    public static bool turnOffButton = false;
    public static int numberOfBrothers;
    public static double brotherPerSec;

    void Update()
    {
        currentCash = GettingMoney._coins;
        priceText.GetComponent<Text>().text = "" + brotherValue.ToString("F0");
        levelText.GetComponent<Text>().text = numberOfBrothers.ToString();
        if (currentCash >= brotherValue)
        {
            fakeButton.SetActive(false);
            realButton.SetActive(true);
        }
        if (currentCash < brotherValue)
        {
            realButton.SetActive(false);
            fakeButton.SetActive(true);
            turnOffButton = false;
        }
    }
    public void BuyUpgrade()
    {
        GettingMoney._coins -= brotherValue;
        brotherValue *= 1.07;
        turnOffButton = true;
        brotherPerSec += 0.3;
        numberOfBrothers += 1;
        PlayerPrefsX.SetDouble("coins", GettingMoney._coins);
        coinsText.text = GettingMoney._coins.ToString("F0");
    }
}
