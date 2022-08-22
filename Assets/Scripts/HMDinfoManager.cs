using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class HMDinfoManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        Debug.Log("Is device active" + XRSettings.isDeviceActive);
        Debug.Log("Device is" + XRSettings.loadedDeviceName);

        if (!XRSettings.isDeviceActive)
        {

            Debug.Log("xd");
        }

       
        
        else if (XRSettings.isDeviceActive && (XRSettings.loadedDeviceName == "Mock HMD" || XRSettings.loadedDeviceName == "MockHMDDisplay"))

        {
            Debug.Log("Mock HMD");

        }

        else
        {
            Debug.Log("We have a headset" + XRSettings.loadedDeviceName);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
