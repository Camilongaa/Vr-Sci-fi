using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenShoots : MonoBehaviour
{
  

  public KeyCode screenShotButton;
void Update()
{
    if (Input.GetKeyDown(screenShotButton))
    {
        ScreenCapture.CaptureScreenshot("screenshot " + System.DateTime.Now.ToString("MM-dd-yy (HH-mm-ss)") + ".png", 4);
        Debug.Log("A screenshot was taken!");
    }
}
}
