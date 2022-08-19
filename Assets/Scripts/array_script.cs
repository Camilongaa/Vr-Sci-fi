using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class array_script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        string[] letras = new string[5]{"a","b","c","d","e"};
        
        letras[2] = "z";
        
        Debug.Log (letras[0]);
        
    }

    // Update is called once per frame
    void Update()
    {
    }
}
