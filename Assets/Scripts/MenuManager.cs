using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Nave Sci FI");
        
    }

    public void QuitGame()
    {
       SceneManager.LoadScene("Main Menu");

    }


    public void Tutorial()
    {
        SceneManager.LoadScene("Tutorial");
    }

    public void BacktoMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    



    
}
