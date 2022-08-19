using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class New_script : MonoBehaviour
{
 public int velocidad;
 private int velocidadMaxima =120;
 private int velocidadMinma = 40;
    void Start()
    {
               
        
    }

    // Update is called once per frame
    void Update()
    {
     if(velocidad > velocidadMaxima){
        Debug.Log("Superado");

     }
     else if(velocidad < velocidadMinma){
        Debug.Log("Minima");
     }
     else{
        Debug.Log("Superado xd");
     }
        
    }
}
