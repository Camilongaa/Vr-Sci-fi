using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colores_nucleo : MonoBehaviour
{
    public GameObject m_EmissiveObject;



    public bool OnPlaying ;

    // Start is called before the first frame update


    void Start()
    {
        OnPlaying = false;

        float emissiveIntensity = 10;
        Color emissiveColor = Color.red;
        m_EmissiveObject.GetComponent<Renderer>().material.SetColor("_EmissiveColor", Color.red * 10);



    }

    // Update is called once per frame
    void Update()
    {


    }
}
