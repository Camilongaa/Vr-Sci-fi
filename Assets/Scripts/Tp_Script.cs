using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class Tp_Script : MonoBehaviour
{
    [Header("Tp Controller")]
    [SerializeField] private XRRayInteractor rayInteractor;
    [SerializeField] private InteractionLayerMask TpLayers;
    [SerializeField] private TeleportationProvider TpProvider;
    [SerializeField] private InputActionProperty TpActivate;
    [SerializeField] private InputActionProperty TpCancel;
    [SerializeField] private InputActionProperty ThumMove;
    [SerializeField] private InputActionProperty GripModeActivate;


    private bool isTpActivate;
    private InteractionLayerMask initialInteractionLayers;
    private List<IXRInteractable> interactables = new List<IXRInteractable>();

    void Start()
    {
        TpActivate.action.Enable();
        TpCancel.action.Enable();
        ThumMove.action.Enable();
        GripModeActivate.action.Enable();

        TpActivate.action.performed += OnTeleportActivate;
        TpCancel.action.performed += OnTeleportCancel;

    }

    private void OnTeleportActivate(InputAction.CallbackContext obj)
    {
        if(GripModeActivate.action.phase != InputActionPhase.Performed)
        {
            isTpActivate = true;
            rayInteractor.lineType = XRRayInteractor.LineType.ProjectileCurve;
            rayInteractor.interactionLayers = TpLayers;
        }

    }


    private void OnTeleportCancel(InputAction.CallbackContext obj)
    {
        TurnOffTp();
    }




    // Update is called once per frame
    void Update()
    {

        if (isTpActivate)
            return;

        if (ThumMove.action.triggered)
            return;

        rayInteractor.GetValidTargets(interactables);
        if (interactables.Count == 0) {
            TurnOffTp();
            return;
        }

        rayInteractor.TryGetCurrent3DRaycastHit(out RaycastHit hit);
        TeleportRequest request = new TeleportRequest();
        if (interactables[0].interactionLayers == 2)
        {

            request.destinationPosition = hit.point;
        }
        else if (interactables[0].interactionLayers == 5)
        {
            request.destinationPosition = hit.transform.GetChild(0).transform.position;
        }

            TpProvider.QueueTeleportRequest(request);
            TurnOffTp();

    }

  
    
    private void TurnOffTp() {
        isTpActivate = false;
        rayInteractor.lineType = XRRayInteractor.LineType.StraightLine;
        rayInteractor.interactionLayers = initialInteractionLayers;
    }
}
