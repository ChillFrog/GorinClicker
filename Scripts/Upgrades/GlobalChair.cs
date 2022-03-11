using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalChair : MonoBehaviour
{
    public GameObject fakeButton;
    public GameObject realButton;
    public GameObject priceText;
    public GameObject levelText;
    public TMPro.TMP_Text coinsText;
    public double currentCash;
    public static double chairValue = 30;
    public static bool turnOffButton = false;
    public static int numberOfChairs;
    public static double chairPerSec;

    void Update()
    {
        currentCash = GettingMoney._coins;
        priceText.GetComponent<Text>().text = "" + chairValue.ToString("F0");
        levelText.GetComponent<Text>().text = numberOfChairs.ToString();
        if (currentCash >= chairValue)
        {
            fakeButton.SetActive(false);
            realButton.SetActive(true);
        }
        if (currentCash < chairValue)
        {
            realButton.SetActive(false);
            fakeButton.SetActive(true);
            turnOffButton = false;
        }
    }
    public void BuyUpgrade()
    {
        GettingMoney._coins -= chairValue;
        chairValue *= 1.08;
        turnOffButton = true;
        chairPerSec += 0.7;
        numberOfChairs += 1;
        PlayerPrefsX.SetDouble("coins", GettingMoney._coins);
        coinsText.text = GettingMoney._coins.ToString("F0");
    }
}
