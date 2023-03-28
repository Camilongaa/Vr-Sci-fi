using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFinalManager : MonoBehaviour
{

    [SerializeField] private GameObject Nave;
    [SerializeField] private Animator Door;
    [SerializeField]public Timer timer;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            Nave.SetActive(false);

            Door.SetBool("Closed", true);
            timer.pause();
        }
    }
}
