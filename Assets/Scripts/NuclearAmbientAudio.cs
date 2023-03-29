using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NuclearAmbientAudio : MonoBehaviour
{
    public AudioSource AmbientNuclear;

    void OnTriggerEnter(Collider other){

        if (other.gameObject.tag == "Player")

        {
           AmbientNuclear.Play();

        }


    }

    void OnTriggerExit(Collider other){

        if(other.gameObject.tag == "Player")
        {
            AmbientNuclear.Pause();
        }
    }

    
}
