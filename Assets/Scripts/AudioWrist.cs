using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Audio;

public class AudioWrist : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {


        StartCoroutine(FirtsAudio());

    }

    IEnumerator FirtsAudio()
    {
        yield return new WaitForSeconds(12);
        this.GetComponent<AudioSource>().Play();
    }
}
