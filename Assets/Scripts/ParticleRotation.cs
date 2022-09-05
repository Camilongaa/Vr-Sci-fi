using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ParticleRotation : MonoBehaviour
{
    public Vector3 speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        s
        transform.Rotate(speed * Time.deltaTime);
    }
}
