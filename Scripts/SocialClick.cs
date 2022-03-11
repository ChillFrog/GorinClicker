using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SocialClick : MonoBehaviour
{
    public bool AppHere;
    private void OnApplicationFocus(bool focus)
    {
        AppHere = !focus;
    }
    private void OnApplicationPause(bool pause)
    {
        AppHere = pause;
    }
    public void OpenTikTok()
    {
        StartCoroutine(Tiktok());
    }
    IEnumerator Tiktok()
    {
        Application.OpenURL("https://www.tiktok.com/@mrkirti_");
        yield return new WaitForSeconds(1f);
    }
    public void OpenYoutube()
    {
        StartCoroutine(Youtube());
    }
    IEnumerator Youtube()
    {
        Application.OpenURL("https://www.youtube.com/c/MrKirTi");
        yield return new WaitForSeconds(1f);
    }
    public void OpenVK()
    {
        StartCoroutine(VK());
    }
    IEnumerator VK()
    {
        Application.OpenURL("https://vk.com/lolec47");
        yield return new WaitForSeconds(1f);
    }
}