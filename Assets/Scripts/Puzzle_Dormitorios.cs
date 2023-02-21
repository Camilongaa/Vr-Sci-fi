using FMOD;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Puzzle_Dormitorios : MonoBehaviour
{

    public float CorrectPosition;
    [SerializeField]
   
    bool isPlaced = false;


    float[] rotations = { 0, 90, 180, 270 };

    private void Start()
    {
        int rand = Random.Range(0, rotations.Length);
        transform.eulerAngles = new Vector3(0, 90, rotations[rand]);
             
        if (transform.eulerAngles.z == CorrectPosition )
        {
            isPlaced = true;
        }
      
    }

    public void Rotate()
    {
        
        transform.Rotate(new Vector3(0,0,90));
        if (transform.eulerAngles.z == CorrectPosition && isPlaced == false)
        {
            isPlaced = true;
        }
        else if (isPlaced == true)
        {
            isPlaced = false;
        }
        
            
        





    }




}
