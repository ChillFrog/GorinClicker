using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadingAway : MonoBehaviour
{
    public Animator animator;
    public void Upgrade()
    {
        if (animator.GetBool("IsFadeAway") == false)
        {
            animator.SetBool("IsFadeAway", true);
            animator.SetTrigger("Disabled");
            animator.ResetTrigger("Normal");
        }

        else if (animator.GetBool("IsFadeAway") == true)
        {
            animator.SetBool("IsFadeAway", false);
            animator.SetTrigger("Normal");
            animator.ResetTrigger("Disabled");
        }
    }
}
