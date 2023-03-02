using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Audio3_player : MonoBehaviour
{
    public AudioSource TercerAudio;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            TercerAudio.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Destroy(gameObject);

    }
}
