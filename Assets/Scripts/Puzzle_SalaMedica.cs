using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.Burst.Intrinsics.X86.Avx;


public class Puzzle_SalaMedica : MonoBehaviour
{
    float speed = 1;
    [Header("Audios")]
    public AudioSource CorrectAnswer;
    public AudioSource WrongAnswer;

    public AudioSource CompuertaOpen;


    [Header("Niveles")]

    public GameObject Level_one;
    public GameObject Level_Two;
    public GameObject Level_Three;
    public GameObject final_screen;

    [Header("Objetos")]
    public GameObject Tarjeta;
    public GameObject Compuerta;
    public GameObject Mission3;
    public GameObject Mission4;
    

    public void Start()
    {
        Level_one.SetActive(true);
        Level_Two.SetActive(false);
        Level_Three.SetActive(false);

        Tarjeta.SetActive(false);

        Mission4.SetActive(false);


    }

    public void RightAnswer1()
    {
        CorrectAnswer.Play();
        Level_one.SetActive(false);
        Level_Two.SetActive(true);
        
    }

    public void RightAnswer2()
    {
        CorrectAnswer.Play();
        Level_Two.SetActive(false);
        Level_Three.SetActive(true);

    }

    public void RightAnswer3()
    {
        CorrectAnswer.Play();
        Level_Two.SetActive(false);
        Level_Three.SetActive(false);
        final_screen.SetActive(true);
        

        abrirCompuerta();

        Tarjeta.SetActive(true);

        Mission3.SetActive(false);
        Mission4.SetActive(true);
    }

    public void Wronganswer()
    {
        WrongAnswer.Play();
    }

    public void abrirCompuerta()
    {
        Destroy(Compuerta);
        CompuertaOpen.Play();
        

    }

}
