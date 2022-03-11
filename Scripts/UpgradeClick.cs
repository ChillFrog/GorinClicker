using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeClick : MonoBehaviour
{
    public Animator animator;
    public void Upgrade()
    {
        if (animator.GetBool("IsUp") == false)
        {
            animator.SetBool("IsUp", true);
        }

        else if (animator.GetBool("IsUp") == true)
        {
            animator.SetBool("IsUp", false);
        }
    }
}
