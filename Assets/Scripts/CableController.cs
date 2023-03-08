using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CableController : MonoBehaviour
{
    [SerializeField] private Transform[] cables;
    [SerializeField] private GameObject winText;
    [SerializeField] private GameObject Luces;
    [SerializeField] private GameObject Tarjeta;
    public static bool youwin;
    private void Start()
    {
        Tarjeta.SetActive(false);
        winText.SetActive(false);
        youwin = false;
        
    }


    private void Update()
    {
       if (cables[0].rotation.z == 0 &&
          cables[1].rotation.z == 0 &&
            cables[2].rotation.z == 0 &&
          cables[3].rotation.z == 0 &&
            cables[4].rotation.z == 0   &&
          cables[5].rotation.z == 0  &&
            cables[6].rotation.z == 0 &&
          cables[7].rotation.z == 0 &&
            cables[8].rotation.z == 0 &&
          cables[9].rotation.z == 0 &&
            cables[10].rotation.z == 0 &&
            cables[11].rotation.z == 0 &&
          cables[12].rotation.z == 0 &&
            cables[13].rotation.z == 0 &&
          cables[14].rotation.z == 0 &&
            cables[15].rotation.z == 0
            )
        {

            youwin = true;
            winText.SetActive(true);
            Tarjeta.SetActive(true);
            Luces.SetActive(true);



        }
            
            
          




    }
}
