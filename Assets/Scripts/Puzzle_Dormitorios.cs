using FMOD;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Puzzle_Dormitorios : MonoBehaviour
{

    public float [] CorrectPosition;
    [SerializeField]
   
    bool isPlaced = false;


    public float[] rotations = { 0, 90, 180, 270 };
    int PossibleRots = 1;

    Manager_Cables managerCables;


    private void Awake()
    {
        managerCables = GameObject.Find("Manager_Cables").GetComponent<Manager_Cables>();
    }

    private void Start()
    {
        PossibleRots = CorrectPosition.Length;


        int rand = Random.Range(0, rotations.Length);
        transform.eulerAngles = new Vector3(0, 90, rotations[rand]);


        if(PossibleRots > 1)
        {
            if (transform.eulerAngles.z == CorrectPosition[0] || transform.eulerAngles.z == CorrectPosition[1])
            {
                isPlaced = true;
                managerCables.CorrectMove();
            }
           
        }

        else  
        {
            if (transform.eulerAngles.z == CorrectPosition[0])
            {
                isPlaced = true;
                managerCables.CorrectMove();

            }
        }







    }

    public void Rotate()
    {
        
        transform.Rotate(new Vector3(0,0,90));

        if (PossibleRots > 1)
        {
            if (transform.eulerAngles.z == CorrectPosition[0] || transform.eulerAngles.z == CorrectPosition[1] && isPlaced == false)
            {
                isPlaced = true;
                managerCables.CorrectMove();

            }


        }

        else if (isPlaced == true)
        {
            isPlaced = false;
            managerCables.wrongMove();
        }
        
        else
        {
            if (PossibleRots > 1)
            {
                if (transform.eulerAngles.z == CorrectPosition[0]  && isPlaced == false)
                {
                    isPlaced = true;
                    managerCables.CorrectMove();

                }


            }

            else if (isPlaced == true)
            {
                isPlaced = false;
                managerCables.wrongMove();
            }

        }






    }




}
