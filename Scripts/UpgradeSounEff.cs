using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeSounEff : MonoBehaviour
{
    public AudioSource AudioSource;
    public void  DoSound()
    {
        AudioSource.Play();
    }
}
