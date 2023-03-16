using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitialDoor : MonoBehaviour
{
    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            anim = GetComponent<Animator>();
            anim.SetBool("Open", true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag    == "Player")
            {
            anim = GetComponent<Animator>();
            anim.SetBool("Open", false);
        }
    }
}
    

