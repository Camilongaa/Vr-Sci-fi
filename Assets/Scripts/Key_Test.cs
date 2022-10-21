using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Key_Test : MonoBehaviour
{
    public AudioSource audioData;

    public Sala_Nuclear_Door doorToOpen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Equals  ("Llave_Sala_medica"))
        {
            doorToOpen.isUnlocked = true;
            audioData.Play(0);
           



        }


    }
}
