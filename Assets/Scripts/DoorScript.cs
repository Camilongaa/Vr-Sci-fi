using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
   
     


{
    public bool isUnlocked = false;
    public Transform OpenPosition;
    public Transform Door;
    public Transform ClosedPosition;
    public float speed = 1f;
    Vector3 targetPosition;
    float time;
    // Start is called before the first frame update
    void Start()
    {
        targetPosition = ClosedPosition.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (isUnlocked && Door.position != targetPosition)
        {
            Door.transform.position = Vector3.Lerp(Door.transform.position, targetPosition, time);
            time += Time.deltaTime * speed;
        }


    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            targetPosition = OpenPosition.position;
            time = 0;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            targetPosition = ClosedPosition.position;
            time = 0;
        }
    }
}
