using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class animateHand : MonoBehaviour
{
    public InputActionReference gripI;
    public InputActionReference triggerI;

    private Animator handAnimator;
    private float gripValue;
    private float triggerValue;

    private void AnimateGrip()
    {
        gripValue = gripI.action.ReadValue<float>();
        handAnimator.SetFloat("Grip", gripValue);
    }
    private void AnimateTrigger()
    {
        gripValue = triggerI.action.ReadValue<float>();
        handAnimator.SetFloat("Trigger", triggerValue);
    }
    // Start is called before the first frame update
    void Start()
    {
        handAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        AnimateGrip();
        AnimateTrigger();
    }
}
