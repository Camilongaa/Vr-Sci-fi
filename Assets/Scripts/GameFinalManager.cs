using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFinalManager : MonoBehaviour
{

    private GameObject Nave;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            Destroy(Nave);
        }
    }
}
