using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Puzzle_Dormitorios : MonoBehaviour
{
    public InputActionAsset inputActions;
    public InputAction Select;

    public float CorrectPosition;
    [SerializeField]
    bool isRotated = false;
    
    float[] rotations = { 0, 90, 180, 270 };

    private void Start()
    {
        int rand = Random.Range(0, rotations.Length);
        transform.eulerAngles = new Vector3(0, 90, rotations[rand]);


        if (Input.GetKeyDown("Select"))
        {
            // transform.Rotate(new Vector3(0, 0, 90));

            if (transform.eulerAngles.z == CorrectPosition )
            {
                isRotated = true;
            }

          
        }
    }


    private void Update()
    {
        if (Input.GetKeyDown("Select"))
        {
           // transform.Rotate(new Vector3(0, 0, 90));

            if(transform.eulerAngles.z == CorrectPosition && isRotated == false)
            {
                isRotated = true;
            }

            else if(isRotated == true)
            {
                isRotated = false;
            }
        }
    }

}
