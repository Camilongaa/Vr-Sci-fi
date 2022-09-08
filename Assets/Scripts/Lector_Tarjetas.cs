using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.OpenXR.Features;


//public class Lector_Tarjetas : XRBaseInteractor
//{
//    private XRBaseInteractable currentInteractable = null;
//    private void OnTriggerEnter(Collider other)
//    {
//        SetInteractable(other);


//    }

//    private void SetInteractable(Collider other)
//    {
//        if (GetInteractableForCollider(other, out XRBaseInteractable interactable)) ;
//        {
//            if (currentInteractable == null)
//                currentInteractable = interactable;
//        }

//    }
//    private void OnTriggerExit(Collider other)
//    {
//        ClearInteractable(other);



//    }

//    private void ClearInteractable(Collider other)
//    {
//        if (GetInteractableForCollider(other, out XRBaseInteractable interactable)) ;
//        {
//            if (currentInteractable == interactable)
//                currentInteractable = null;
//        }

//    }

//    private bool TryGetInteractable(Collider collider, out XRBaseInteractable interactable)
//    {
//        interactable = interactionManager.GetInteractableForCollider(collider);
//        return interactable != null;
//    }
//    public override void GetValidTargets(List<XRBaseInteractable> validTargets)
//    {
//        validTargets.Clear();
//        validTargets.Add(currentInteractable);

//     }
    
//    public override bool canHover
//    {
//        return base.CanHover(interactable) && currentInteractable == interactable;
//    }

//    public override bool CanSelect(XRBaseInteractable interactable)
//    {

//        return false;
//    }

//}
