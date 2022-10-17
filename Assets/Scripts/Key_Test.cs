using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key_Test : MonoBehaviour
{
    public DoorScript doorToOpen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            doorToOpen.isUnlocked = true;

        }

        Destroy(gameObject);
    }
}
