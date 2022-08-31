using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IA_robot : MonoBehaviour
{
    public float interactionRange;
    public LayerMask playerLayer;
    bool interaction;
    public Transform player;
    public float speed;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        interaction = Physics.CheckSphere(transform.position, interactionRange, playerLayer);
        if(interaction == true)
        {
            Vector3 PlayerPos = new Vector3(player.position.x, player.position.y, player.position.z);
            transform.LookAt(PlayerPos);
            transform.position = Vector3.MoveTowards(transform.position, PlayerPos, speed * Time.deltaTime);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, interactionRange);
    }
}
