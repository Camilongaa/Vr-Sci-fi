using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimonSays_Manager : MonoBehaviour
{
    public GameObject GameCanvas;
    private void Start()
    {
        GameCanvas.SetActive(false);
    }

    public  void StartGame()
    {
        GameCanvas.SetActive(true);

        Destroy(this.gameObject);
    }
}
