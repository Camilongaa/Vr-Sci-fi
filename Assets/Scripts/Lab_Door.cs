using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab_Door : MonoBehaviour
{

    public GameObject movingDoor;


    bool playerIsHere;

    public Transform OpenPosition;
    public Transform ClosedPosition;

    // Start is called before the first frame update
    void Start()
    {
        playerIsHere = false;

        movingDoor.transform.position = (ClosedPosition.localPosition);
    }

    // Update is called once per frame
    void Update()
    {
        if (playerIsHere)
        {
            movingDoor.transform.position = (OpenPosition.position);
        }
        else
        {
            movingDoor.transform.position = (ClosedPosition.position);
        }


    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            playerIsHere = true;
        }
    }

    private void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            playerIsHere = false;
        }
    }
}