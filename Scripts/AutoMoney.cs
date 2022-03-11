using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class AutoMoney : MonoBehaviour
{
    public bool CreatingMoney = false;
    public static double MoneyIncrease;
    public GameObject GPS;
    public double InternalIncrease;
    [SerializeField] private TMP_Text _coinsText;

    private void Start()
    {
        Load();
    }
    void Update()
    {
        Save();
        MoneyIncrease = GlobalChair.chairPerSec + GlobalFreezer.freezerPerSec + GlobalBrother.brotherPerSec + GlobalFanta.fantasPerSec ;
        InternalIncrease = MoneyIncrease;
        GPS.GetComponent<Text>().text = MoneyIncrease.ToString("F1") + "/с";
        if (CreatingMoney == false)
        {
            CreatingMoney = true;
            _coinsText.text = GettingMoney._coins.ToString("F0");
            if (GettingMoney._coins >= 1000)
                _coinsText.text = (GettingMoney._coins / 1000).ToString("F1") + " тыс";
            if (GettingMoney._coins >= 1000000)
                _coinsText.text = (GettingMoney._coins / 1000000).ToString("F1") + " мил";
            if (GettingMoney._coins >= 1000000000)
                _coinsText.text = (GettingMoney._coins / 1000000000).ToString("F1") + " млрд";
            if (GettingMoney._coins >= 1000000000000)
                _coinsText.text = (GettingMoney._coins / 1000000000000).ToString("F1") + " трлн";
            GettingMoney._coins += InternalIncrease * Time.deltaTime;
            CreatingMoney = false;
        }
    }
    public void Load()
    {
        GettingMoney._coins = PlayerPrefsX.GetDouble("coins");
        GlobalFreezer.freezerValue = double.Parse(PlayerPrefs.GetString("freezerValue"));
        GlobalFreezer.freezerPerSec = double.Parse(PlayerPrefs.GetString("freezerPerSec","0"));
        GlobalFreezer.numberOfFreezers = PlayerPrefs.GetInt("numberOfFreezers",0);

        GlobalFanta.fantaValue = double.Parse(PlayerPrefs.GetString("fantaValue"));
        GlobalFanta.fantasPerSec = double.Parse(PlayerPrefs.GetString("fantasPerSec","0"));
        GlobalFanta.numberOfFantas = PlayerPrefs.GetInt("numberOfFantas",0);

        GlobalChair.chairValue = double.Parse(PlayerPrefs.GetString("chairValue"));
        GlobalChair.chairPerSec = double.Parse(PlayerPrefs.GetString("chairPerSec","0"));
        GlobalChair.numberOfChairs = PlayerPrefs.GetInt("numberOfChairs",0);

        GlobalBrother.brotherValue = double.Parse(PlayerPrefs.GetString("brotherValue"));
        GlobalBrother.brotherPerSec = double.Parse(PlayerPrefs.GetString("brotherPerSec","0"));
        GlobalBrother.numberOfBrothers = PlayerPrefs.GetInt("numberOfBrothers",0);
    }
    public static void Save()
    {
        PlayerPrefsX.SetDouble("coins", GettingMoney._coins);
        PlayerPrefs.SetString("freezerValue", GlobalFreezer.freezerValue.ToString());
        PlayerPrefs.SetString("freezerPerSec", GlobalFreezer.freezerPerSec.ToString());
        PlayerPrefs.SetString("fantaValue", GlobalFanta.fantaValue.ToString());
        PlayerPrefs.SetString("fantasPerSec", GlobalFanta.fantasPerSec.ToString());
        PlayerPrefs.SetString("chairValue", GlobalChair.chairValue.ToString());
        PlayerPrefs.SetString("chairPerSec", GlobalChair.chairPerSec.ToString());
        PlayerPrefs.SetString("brotherValue", GlobalBrother.brotherValue.ToString());
        PlayerPrefs.SetString("brotherPerSec", GlobalBrother.brotherPerSec.ToString());
        PlayerPrefs.SetInt("numberOfFreezers", GlobalFreezer.numberOfFreezers);
        PlayerPrefs.SetInt("numberOfFantas", GlobalFanta.numberOfFantas);
        PlayerPrefs.SetInt("numberOfChairs", GlobalChair.numberOfChairs);
        PlayerPrefs.SetInt("numberOfBrothers", GlobalBrother.numberOfBrothers);

    }
    public void DeletePrefs()
    {
        GettingMoney._coins = 0;
        GlobalFreezer.freezerValue = 200;
        GlobalFreezer.freezerPerSec = 0;
        GlobalFreezer.numberOfFreezers = 0;

        GlobalFanta.fantaValue = 500;
        GlobalFanta.fantasPerSec = 0;
        GlobalFanta.numberOfFantas = 0;

        GlobalChair.chairValue = 30;
        GlobalChair.chairPerSec = 0;
        GlobalChair.numberOfChairs = 0;

        GlobalBrother.brotherValue = 10;
        GlobalBrother.brotherPerSec = 0;
        GlobalBrother.numberOfBrothers = 0;
    }
}
