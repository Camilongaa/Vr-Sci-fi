using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class Spin : MonoBehaviour
{
    [SerializeField] private InputActionProperty TpActivate;
    [SerializeField] private InputActionProperty TpCancel;
    [SerializeField] private InputActionProperty ThumMove;
    [SerializeField] private InputActionProperty GripModeActivate;




    void Start()
    {
        TpActivate.action.Enable();
        TpCancel.action.Enable();
        ThumMove.action.Enable();
        GripModeActivate.action.Enable();

        TpActivate.action.performed += OnTeleportActivate;
        TpCancel.action.performed += OnTeleportCancel;

    }

    // Update is called once per frame
    void Update()
    {


        transform.Rotate(0, 0, 30 * Time.deltaTime);
    }
}
