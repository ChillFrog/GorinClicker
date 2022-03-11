using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuSquarePrestige : MonoBehaviour
{
    public Animator animator;
    public void Upgrade()
    {
        if (animator.GetBool("IsPrestige") == false)
        {
            animator.SetBool("IsPrestige", true);
        }

        else if (animator.GetBool("IsPrestige") == true)
        {
            animator.SetBool("IsPrestige", false);
        }
    }
}