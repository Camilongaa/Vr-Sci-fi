using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Key_Test : MonoBehaviour
{
    public AudioSource audioData;

    public DoorScriptV2 doorToOpen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Equals  ("Test_tarjetas"))
        {
            doorToOpen.isUnlocked = true;
            audioData.Play(0);



        }


    }
}
