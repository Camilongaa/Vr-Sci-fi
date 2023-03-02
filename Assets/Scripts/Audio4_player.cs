using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Audio4_player : MonoBehaviour
{
    public AudioSource CuartoAudio;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            CuartoAudio.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Destroy(gameObject);

    }
}
