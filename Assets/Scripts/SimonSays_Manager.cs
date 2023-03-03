using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimonSays_Manager : MonoBehaviour
{
    public GameObject GameCanvas;
    public GameObject Background1;
    private void Start()
    {
        GameCanvas.SetActive(false);
    }

    public  void StartGame()
    {
        GameCanvas.SetActive(true);
        Background1.SetActive(false);

        Destroy(this.gameObject);
    }
}
