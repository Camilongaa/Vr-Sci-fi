using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SF_TP : MonoBehaviour
{

    [SerializeField] private AudioSource _audioClip;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            _audioClip.Play();
        }
    }
}
