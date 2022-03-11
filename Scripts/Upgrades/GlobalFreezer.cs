using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalFreezer : MonoBehaviour
{
    public GameObject fakeButton;
    public GameObject realButton;
    public GameObject priceText;
    public GameObject levelText;
    public TMPro.TMP_Text coinsText;
    public double currentCash;
    public static double freezerValue = 200;
    public static bool turnOffButton = false;
    public static int numberOfFreezers;
    public static double freezerPerSec;
    public AudioSource upgradeSound;

    void Update()
    {
        currentCash = GettingMoney._coins;
        priceText.GetComponent<Text>().text = "" + freezerValue.ToString("F0");
        levelText.GetComponent<Text>().text = numberOfFreezers.ToString();
        if (currentCash >= freezerValue)
        {
            fakeButton.SetActive(false);
            realButton.SetActive(true);
        }
        if (currentCash <freezerValue)
        {
            realButton.SetActive(false);
            fakeButton.SetActive(true);
            turnOffButton = false;
        }
    }
    public void BuyUpgrade()
    {
        GettingMoney._coins -= freezerValue;
        freezerValue *= 1.09;
        turnOffButton = true;
        freezerPerSec += 1.5;
        numberOfFreezers += 1;
        PlayerPrefsX.SetDouble("coins", GettingMoney._coins);
        coinsText.text = GettingMoney._coins.ToString("F0");
    } 
}
