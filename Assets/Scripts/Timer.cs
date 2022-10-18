using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private PlayerHealt player;


    [Tooltip("Tiempo inicial")]
    public int InitialTime;
    [Range(-10, 10)]
    public float TimeScale = 1;
    private Text mytext;
    private float FrameTimeWithTimeScale = 0f;
    private float timeInseconds;
    private float Scaletimepaused, InitialTimeScale;
    private bool isPaused = false;
    private bool timeIsUp = false;

 
    public AudioClip SecondsSound;
    private int secondspreviousframe = -1;
    private AudioSource myAudioSource;
    

    public delegate void Finishtime();
    public static event Finishtime Alterminartiempo;


    public delegate void ChangingSeconds();
    public static event ChangingSeconds atChangingSeconds;

    private void OnEnable()
    {
        Timer.atChangingSeconds += Cambiarsegundos;
    }
    private void OnDisable()
    {
        Timer.atChangingSeconds -= Cambiarsegundos;
    }


    // Start is called before the first frame update
    void Start()
    {
        if (SecondsSound)
        {
            myAudioSource = this.gameObject.AddComponent<AudioSource>();
            myAudioSource.clip = SecondsSound;
            myAudioSource.playOnAwake = false;

        }


        InitialTimeScale = TimeScale;

        mytext = GetComponent<Text>();

        timeInseconds = InitialTime;

        ActualizarTimer(InitialTime);
    }

    // Update is called once per frame
    void Update()
    {
        if (!isPaused)
        {
            FrameTimeWithTimeScale = Time.deltaTime * TimeScale;

            timeInseconds += FrameTimeWithTimeScale;
            ActualizarTimer(timeInseconds);
        }


    }
    public void ActualizarTimer(float timeInseconds)
    {



        int minute = 0;
        int seconds = 0;
        string ClockText;

        if (timeInseconds <= 0 && !timeIsUp) {

            if (Alterminartiempo != null)
            {
                Alterminartiempo();
            }

            timeIsUp = true;
        }

        if (timeInseconds < 0) timeInseconds = 0;

        minute = (int)timeInseconds / 60;
        seconds = (int)timeInseconds % 60;

        ClockText = minute.ToString("00") + ":" + seconds.ToString("00");
        mytext.text = ClockText;

        if (secondspreviousframe > -1)
        {
            if (seconds != secondspreviousframe)
            {

                atChangingSeconds();
            }
            secondspreviousframe = seconds;

        }


    }


    public void pause()
    {
        if (!isPaused)
        {
            isPaused = true;
            Scaletimepaused = TimeScale;
            TimeScale = 0;
            

        }

    }

    public void continuee (){
        if (isPaused)
        {
            isPaused = false;
            TimeScale = Scaletimepaused;
        }

 }

    public void restart()
    {
        isPaused = false;
        TimeScale = InitialTimeScale;
        timeInseconds = InitialTimeScale;
        ActualizarTimer(timeInseconds);
        timeIsUp = false;


    }


    void Cambiarsegundos()
    {

        if (SecondsSound)
        {
            myAudioSource.Play();
        }
    }

}
