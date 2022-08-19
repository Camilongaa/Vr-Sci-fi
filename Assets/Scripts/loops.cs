using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loops : MonoBehaviour
{
    public int [] numeros = new int [6]{15,20,56,67,42,5};
    int incremento = 0;
    void Start()
    {
        Debug.Log(incremento);
       for (int i=0; 1 <numeros.Length; i++){
        Debug.Log(numeros [i]);
        incremento ++;
       }
               Debug.Log(incremento);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
