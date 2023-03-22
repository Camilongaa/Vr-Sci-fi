using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealt : MonoBehaviour
{


    private void OnEnable()
    {
        Timer.Alterminartiempo += Death;
    }

    private void OnDisable()
    {
        Timer.Alterminartiempo -= Death;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void Death()
    {
        SceneManager.LoadScene(0);
       // SceneManager.LoadScene(SceneManager.GetActiveScene().name);


    }
}
