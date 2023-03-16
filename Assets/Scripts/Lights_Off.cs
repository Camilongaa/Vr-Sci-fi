using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;


public class Lights_Off : MonoBehaviour
{
    public GameObject lights;
    public AudioSource Dialogo09;

    public  void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            lights.gameObject.SetActive(false);

            Dialogo09.Play();
        }
        

        

    }

    private void OnTriggerExit(Collider other)
    {
        Delete();
    }

    private void Delete()
    {
        Destroy(this.gameObject);
    }
   
}
