using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager_Cables : MonoBehaviour
{

    public GameObject CablesHolder;
    public GameObject[] Cables;

    [SerializeField]
    int totalcables = 0;

    // Start is called before the first frame update
    void Start()
    {
        totalcables = CablesHolder.transform.childCount;

        Cables = new GameObject[totalcables];

        for (int i = 0; i < Cables.Length; i++)
        {
            Cables[i] = CablesHolder.transform.GetChild(i).gameObject;

        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
