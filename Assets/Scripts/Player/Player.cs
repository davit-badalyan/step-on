using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private static Player instance;
    public static Player Instance
    {
        get
        {
            if (instance == null)
            {
                Debug.LogError("Player is NULL");
            }

            return instance;
        }
    }

    private Animator animator;
    public InputHandler inputHandler;
    public MovementHandler movementHandler;
    public Vector3 startPosition = new Vector3(0, 0, 0);

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        Init();
        Resume();
    }

    private void Update()
    {
        KeepInCenter();
    }

    private void Init()
    {
        animator = GetComponent<Animator>();
    }

    private void Resume()
    {
        transform.position = startPosition;
        transform.rotation = Quaternion.identity;
    }

    private void KeepInCenter()
    {
        transform.rotation = Quaternion.identity;
        transform.position = new Vector3(0, 0, transform.position.z);
    }

    private void SwitchToLeftLegLayer()
    {
        animator.SetLayerWeight(2, 1);
        animator.SetLayerWeight(3, 0.0f);
    }

    private void SwitchToRightLegLayer()
    {
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

    public void SetLeftLegActive()
    {
        animator.SetBool("isLeftLegActive", true);
        animator.SetBool("isRightLegActive", false);

        SwitchToLeftLegLayer();
    }

    public void SetRightLegActive()
    {
        animator.SetBool("isRightLegActive", true);
        animator.SetBool("isLeftLegActive", false);

        SwitchToRightLegLayer();
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
