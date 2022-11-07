using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Puzzle_SalaMedica : MonoBehaviour
{

    [Header("Audios")]
    public AudioSource CorrectAnswer;
    public AudioSource WrongAnswer;

    [Header("Niveles")]

    public GameObject Level_one;
    public GameObject Level_Two;
    public GameObject Level_Three;

    [Header("Tarjeta")]
    public GameObject Tarjeta;

    public void Start()
    {
        Level_one.SetActive(true);
        Level_Two.SetActive(false);
        Level_Three.SetActive(false);

        Tarjeta.SetActive(false);


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
        Level_Three.SetActive(true);

        Tarjeta.SetActive(true);
    }

    public void Wronganswer()
    {
        WrongAnswer.Play();
    }

}
