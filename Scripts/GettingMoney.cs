using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class GettingMoney : MonoBehaviour
{
    public static double _coins;
    [SerializeField] private TMP_Text _coinsText;
    [SerializeField] public bool _fxIsOn = true;
    [SerializeField] private double _coinsMultiplier;
    [SerializeField] private GameObject _clickFX;
    [SerializeField] private RectTransform _buttonPosition;
    public AudioSource gorin1;
    public AudioSource gorin2;
    public int generateTone;
    public Animator animator;

    // Start is called before the first frame update
    public void Start()
    {
            _coinsText.text = _coins.ToString("F1");
            if(_coins >= 1000)
            _coinsText.text = (_coins / 1000).ToString("F1") + " тыс";
            if (_coins >= 1000000)
                _coinsText.text = (_coins / 1000000).ToString("F1") + " мил";
            if (_coins >= 1000000000)
                _coinsText.text = (_coins / 1000000000).ToString("F1") + " млдр";
            if (_coins >= 1000000000000)
                _coinsText.text = (_coins / 1000000000000).ToString("F1") + " трлн";

    }
    public void EarnMoney()
    {
        generateTone = UnityEngine.Random.Range(1, 3);
        if(generateTone == 1)
        {
            gorin1.Play();
        }
        if (generateTone == 2)
        {
            gorin2.Play();
        }
        if (_fxIsOn)
        {
            Instantiate(_clickFX, _buttonPosition.position.normalized, Quaternion.identity); 
        }
        _coins += _coinsMultiplier;
        _coinsText.text = _coins.ToString("F0");
        if (_coins >= 1000)
            _coinsText.text = (_coins / 1000).ToString("F1") + " тыс";
        if (_coins >= 1000000)
            _coinsText.text = (_coins / 1000000).ToString("F1") + " мил";
        if (_coins >= 1000000000)
            _coinsText.text = (_coins / 1000000000).ToString("F1") + " млдр";
        if (_coins >= 1000000000000)
            _coinsText.text = (_coins / 1000000000000).ToString("F1") + " трлн";
    }
    public void EffectToggle()
    {
        if (_fxIsOn == true && animator.GetBool("IsOn") == true)
        {
            _fxIsOn = false;
            animator.SetBool("IsOn", false);
            _clickFX.SetActive(false);
        }
        else if(_fxIsOn == false && animator.GetBool("IsOn") == false)
        {
            _fxIsOn = true;
            animator.SetBool("IsOn", true);
            _clickFX.SetActive(true);
        }
    }
}
