using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle_Audio : MonoBehaviour
{
    [Header("Audios")]
    public AudioSource Explicacion;
    public AudioSource Aullido;

    [Header("Componentes")]
    
    bool IsActive;
    public Transform Object;
    public Transform EnabledPosition;
    public Transform DisabledPosition;
    public float speed;
    Vector3 Targerposition;
    float time;


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
            {
            Targerposition = EnabledPosition.position;
            time = 0;
            Explicacion.Play();
            StartCoroutine("answer1");
            

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            Targerposition = DisabledPosition.position;
            time = 0;
        }
    }

    private void Update()
    {
        if (Object.position != Targerposition)
        {
            Object.transform.position = Vector3.Lerp(Object.transform.position, Targerposition, time);
            time += Time.deltaTime * speed;

        }
    }

    private void Start()
    {
        Targerposition = DisabledPosition.position;
    }

    IEnumerator answer1()
    {
        yield return new WaitForSeconds(43);
        Aullido.Play();


    }
}
