using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUpShop : MonoBehaviour
{
    public Animator animator;
    public void Upgrade()
    {
        if (animator.GetBool("IsShop") == false)
        {
            animator.SetBool("IsShop", true);
        }

        else if (animator.GetBool("IsShop") == true)
        {
            animator.SetBool("IsShop", false);
        }
    }
}
