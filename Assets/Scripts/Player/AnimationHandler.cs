using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationHandler : MonoBehaviour
{
    private Animator animator;
    public Player player;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void SetLeftLegActive()
    {
        animator.SetBool("isLeftLegActive", true);
        animator.SetBool("isRightLegActive", false);

        animator.SetLayerWeight(2, 1);
        animator.SetLayerWeight(3, 0.0f);
    }

    private void SetRightLegActive()
    {
        animator.SetBool("isRightLegActive", true);
        animator.SetBool("isLeftLegActive", false);

        animator.SetLayerWeight(3, 1);
        animator.SetLayerWeight(2, 0.0f);
    }

    public void OnLeftStepComplete()
    {
        SetRightLegActive();
    }

    public void OnRightStepComplete()
    {
        SetLeftLegActive();
    }

    public void SetLeftTransition()
    {
        bool isLeftLegActive = animator.GetBool("isLeftLegActive");

        if (!isLeftLegActive)
        {
            animator.SetTrigger("transition");
            SetLeftLegActive();
        }
    }

    public void SetRightTransition()
    {
        bool isRightLegActive = animator.GetBool("isRightLegActive");

        if (!isRightLegActive)
        {
            animator.SetTrigger("transition");
            SetRightLegActive();
        }
    }
}
