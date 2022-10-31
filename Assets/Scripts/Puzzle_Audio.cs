using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle_Audio : MonoBehaviour
{

    public bool isActive = false;
    public Transform EnabledPosition;
    public Transform PuzzleScreen;
    public Transform DisabledPosition;
    public float speed = 1f;
    Vector3 targetPosition;
    float time;
    // Start is called before the first frame update
    //
    void Start()
    {
        targetPosition = DisabledPosition.position;
        
    }

    private void OnTriggerEnter(Collider other)

    {
        if (other.tag == "Player")
        {
            targetPosition = EnabledPosition.position;
            time = 0;
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            isActive = true;
            targetPosition = DisabledPosition.position;
            time = 0;

            Debug.Log("Activado");
        }
    }
   

    // Update is called once per frame
    void Update()
    {
        if (isActive && PuzzleScreen.position != targetPosition)
        {
            PuzzleScreen.transform.position = Vector3.Lerp(PuzzleScreen.transform.position, targetPosition, time);
            time += Time.deltaTime * speed;
        }

    }
}
