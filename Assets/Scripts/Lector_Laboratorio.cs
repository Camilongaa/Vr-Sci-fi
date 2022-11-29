using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Lector_Laboratorio : MonoBehaviour
{
    public AudioSource audioData;
    public AudioSource Concedido;
    public AudioSource Denegado;
    public AudioSource Opening;


    public Sala_Nuclear_Door doorToOpen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name != ("05 Nuclear"))
        {
            Denegado.Play(); 

        }
        if (other.gameObject.name.Equals  ("05 Nuclear"))
        {
            audioData.Play(0);


            StartCoroutine("Open");
           



        }


    }

    IEnumerator Open()

    {
        yield return new WaitForSeconds(3);

        Concedido.Play();
        Opening.Play();
        doorToOpen.isUnlocked = true;



    }
}
