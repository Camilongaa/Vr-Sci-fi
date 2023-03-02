using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;
using static Unity.Burst.Intrinsics.X86.Avx;

public class ScreenShoots : MonoBehaviour


    
{

    public InputActionAsset InputActions;
    private InputAction Capture;



    public KeyCode screenShotButton;
    private void Start()
    {

        Capture = InputActions.FindActionMap("Keyboard").FindAction("Screenshot");
        Capture.performed += CaptureScreen;
    }
    public void CaptureScreen(InputAction.CallbackContext context)
    {
        
            ScreenCapture.CaptureScreenshot("screenshot " + System.DateTime.Now.ToString("MM-dd-yy (HH-mm-ss)") + ".png", 4);
            Debug.Log("A screenshot was taken!");
        
    }
}
