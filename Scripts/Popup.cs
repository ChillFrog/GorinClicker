using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Popup : MonoBehaviour
{
    public Canvas canvas;
    public bool popupA = false;
    public AudioSource settingsSound;
    public void popup()
    {
        settingsSound.Play();
        if(popupA == false)
        {
            popupA = true;
            canvas.enabled = true;
        }
        else if(popupA == true)
        {
            popupA = false;
            canvas.enabled = false;
        }
    }
}
