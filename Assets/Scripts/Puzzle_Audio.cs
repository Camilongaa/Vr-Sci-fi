using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle_Audio : MonoBehaviour
{
    [Header("Interfaces")]
    public GameObject Firts_Level;
    public GameObject Second_Level;
    public GameObject third_Level;

    [Header("Audios")]
    public AudioSource Explicacion;
    public AudioSource Aullido;
    public AudioSource Cascada;
    public AudioSource Audio3;
    public AudioSource Correct_Answer;
    public AudioSource Wrong_Answer;

    public AudioSource DialogoFinal;






    [Header("Componentes")]
    public GameObject Tarjeta;
    public Transform Object;
    public Transform EnabledPosition;
    public Transform DisabledPosition;
    public float speed;
    Vector3 Targerposition;

    public GameObject TextoTarjeta;



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
            Destroy(this.gameObject);
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
        Firts_Level.SetActive(false);
        Second_Level.SetActive(false);
        third_Level.SetActive(false);
        TextoTarjeta.SetActive(false);
    }

    IEnumerator answer1()
    {
        yield return new WaitForSeconds(12);

        Firts_Level.SetActive(true);
        Aullido.Play();


    }

    public void answer2()


    {
        Correct_Answer.Play();
        Firts_Level.SetActive(false);
        Second_Level.SetActive(true);

        StartCoroutine("Cascadatime");







    }

    public void answer3()
    {
        Second_Level.SetActive(false);
        third_Level.SetActive(true);

        Audio3.Play();




    }


    public void wrongAnswer()
    {
        Wrong_Answer.Play();

    }

    public void atWin()
    {
        Tarjeta.SetActive(true);
        third_Level.SetActive(false);


        Second_Level.SetActive(false);
        TextoTarjeta.SetActive(true);

        DialogoFinal.Play();

    }

    IEnumerator Cascadatime()
    {
        yield return new WaitForSeconds(4);


        Cascada.Play();


    }


    public void Replay3()
    {
        Audio3.Play();
    }

    public void Replay1()
    {
        Aullido.Play();


    }

    public void Replay2()
    {
        Cascada.Play();
    }

   

}
