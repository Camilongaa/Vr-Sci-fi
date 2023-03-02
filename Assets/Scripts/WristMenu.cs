using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class WristMenu : MonoBehaviour
{
     

    public InputActionAsset InputActions;
    private Canvas _WristCanvas;
    private InputAction _menu;

    // Start is called before the first frame update
    void Start()
    {
        _WristCanvas = GetComponent<Canvas>();
        _menu = InputActions.FindActionMap("XRI LeftHand").FindAction("Menu");
        _menu.Enable();
        _menu.performed += ToggleMenu;

    }

    private void OnDestroy()
    {
        _menu.performed -= ToggleMenu;
    }

    // Update is called once per frame
    public void ToggleMenu(InputAction.CallbackContext context)
    {
        _WristCanvas.enabled = !_WristCanvas.enabled;


    }



}
