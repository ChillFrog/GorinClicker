using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundsManager : MonoBehaviour
{
    [SerializeField] public Slider volumeSlider;
    void Start()
    {
        if (!PlayerPrefs.HasKey("musicvalue"))
        {
            PlayerPrefs.SetFloat("musicValue", 1);
            Load();
        }
    }

    private void Load()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("musicVolume");
    }

    public void ChangeVolume()
    {
        AudioListener.volume = volumeSlider.value;
        Save();
    }

    private void Save()
    {
        PlayerPrefs.SetFloat("musicVolume", volumeSlider.value);
    }
}
