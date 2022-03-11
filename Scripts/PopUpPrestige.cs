using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUpPrestige : MonoBehaviour
{
    public GameObject gameObject1;
    public bool popupA = false;
    public AudioSource settingsSound;
    public void popup()
    {
        settingsSound.Play();
        if (popupA == false)
        {
            popupA = true;
            gameObject1.active = true;
        }
        else if (popupA == true)
        {
            popupA = false;
            gameObject1.active = false;
        }
    }
}
