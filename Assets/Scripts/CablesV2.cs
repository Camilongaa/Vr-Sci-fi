using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CablesV2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void rotate()
    {
        if(!CableController.youwin)
        transform.Rotate(0, 0, 90);
    }
}
