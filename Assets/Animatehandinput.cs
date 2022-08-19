using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Animatehandinput : MonoBehaviour
{
    [Header("Animator Input")]
    public Animator HandAnimator;
    [Header("Interaction inputs")]

    public InputActionProperty pichAnimation;
    public InputActionProperty gripAnimation;
    // Start is called before the first frame update
    void Start()
    {
        




    }

    // Update is called once per frame
    void Update()
    {

       float triggerValue = pichAnimation.action.ReadValue<float>();
        HandAnimator.SetFloat("Trigger", triggerValue);

        float gripValue = gripAnimation.action.ReadValue<float>();
        HandAnimator.SetFloat("Grip", gripValue);
    }
}
