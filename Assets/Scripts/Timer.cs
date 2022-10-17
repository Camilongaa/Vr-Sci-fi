using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public PlayerHealt player;


    [Tooltip("Tiempo inicial")]
    public int InitialTime;
    [Range(-10 , 10)]
    public float TimeScale = 1;
    private Text mytext;
    private float FrameTimeWithTimeScale = 0f;
    private float timeInseconds;
    private float Scaletimepaused, InitialTimeScale;
    private bool isPaused = false;


    // Start is called before the first frame update
    void Start()
    {
        InitialTimeScale = TimeScale;

        mytext = GetComponent<Text>();

        timeInseconds = InitialTime;

        ActualizarTimer(InitialTime);
    }

    // Update is called once per frame
    void Update()
    {
        FrameTimeWithTimeScale = Time.deltaTime * TimeScale;

        timeInseconds += FrameTimeWithTimeScale;
        ActualizarTimer(timeInseconds);


    }
    public void ActualizarTimer( float timeInseconds)
    {
        int minute = 0;
        int seconds = 0;
        string  ClockText;

        if (timeInseconds < 0) timeInseconds = 0;

        minute = (int)timeInseconds / 60;
        seconds = (int)timeInseconds % 60;

        ClockText = minute.ToString("00") + ":" + seconds.ToString("00");
        mytext.text = ClockText;


    }
}
