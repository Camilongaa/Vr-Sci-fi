using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
   
     


{
    public Transform OpenPosition;
    public Transform Door;
    public Transform ClosedPosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        


    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Door.position = OpenPosition.position;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            Door.position = ClosedPosition.position;
        }
    }
}
