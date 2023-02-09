using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
   
    


        public static GameManager instance;

    private void Awake()
    {
        if (GameManager.instance != this)
        {
            GameManager.instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(GameManager.instance);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
