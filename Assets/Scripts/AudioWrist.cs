using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Audio;

public class AudioWrist : MonoBehaviour
{
  
    [Header("Audio")]
    [SerializeField]AudioSource FirtsAudioSource;
    [SerializeField]AudioSource SecondAudioSource;

    void Start()
    {

        FirtsAudioSource = GetComponent<AudioSource>();
        SecondAudioSource = GetComponent<AudioSource>();
        StartCoroutine(FirtsAudio());

      //  StartCoroutine(SecondAudio());

    }

    IEnumerator FirtsAudio()
    {
        yield return new WaitForSeconds(5);
        FirtsAudioSource.Play();
    }


    /*IEnumerator SecondAudio()
    {
        yield return new WaitForSeconds(10);
        SecondAudioSource.Play();
    }
    */


}
