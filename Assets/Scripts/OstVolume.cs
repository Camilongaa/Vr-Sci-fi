using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class OstVolume : MonoBehaviour
{

    public AudioSource Ost;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Ost.volume = 0.5f;
        }
    }
}
