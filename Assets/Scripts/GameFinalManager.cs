using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFinalManager : MonoBehaviour
{

    [SerializeField] private GameObject Nave;
    [SerializeField] private Animator Door;
    [SerializeField]public Timer timer;
    [SerializeField] private  GameObject CreditsCanvas;
     [SerializeField] private GameObject Teleports;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            Nave.SetActive(false);

            Door.SetBool("Closed", true);
            timer.pause();

            CreditsCanvas.SetActive(true);
            Teleports.SetActive(false);
        }
    }
}
