using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sala_Nuclear_Door: MonoBehaviour




{
    public bool isUnlocked = false;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (isUnlocked == true)
        {
            GetComponent<Animator>().SetTrigger("Open");



        }


    }


}
