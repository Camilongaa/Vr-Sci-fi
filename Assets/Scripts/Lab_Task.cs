using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Lab_Task : MonoBehaviour
{
    string Code = "320805118";
    string Nr = null;
    int NrIndex = 0;
    string alpha;
    public Text UiText = null;

    [SerializeField]
    public GameObject Door;

    private void Start()
    {
        Door.SetActive(true);
    }
    public void CodeFunction(string Numbers)
    {
        NrIndex++;
        Nr = Nr + Numbers;
        UiText.text = Nr;

    }
    public void Enter()
    {
        if (Nr == Code)
        {
            Debug.Log("Correct");

            Door.SetActive(false);
            

        }
    }
    public void Delete()
    {
        NrIndex++;
        Nr = null;
        UiText.text = Nr;
    }
}