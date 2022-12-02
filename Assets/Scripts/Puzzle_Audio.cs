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
    public AudioSource Correct_Answer;
    public AudioSource Wrong_Answer;



    [Header("Componentes")]
    public GameObject Tarjeta;
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
        Firts_Level.SetActive(false); 
        Second_Level.SetActive(false);
        third_Level.SetActive(false);

    }

    IEnumerator answer1()
    {
        yield return new WaitForSeconds(16);

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


    }


    public void wrongAnswer()
    {
        Wrong_Answer.Play();

    }

    public void atWin()
    {
        Tarjeta.SetActive(true);
        third_Level.SetActive(false);

        Destroy(this.gameObject);


    }

    IEnumerator Cascadatime()
    {
        yield return new WaitForSeconds(3);


        Cascada.Play();


    }




}
