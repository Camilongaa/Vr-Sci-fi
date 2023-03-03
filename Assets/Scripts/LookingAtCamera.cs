using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LookingAtCamera : MonoBehaviour
{

    public Transform LookAt;
    public Transform LocalTrans;

    private void Start()
    {

        LocalTrans = this.GetComponent<Transform>();
    }

    private void Update()
    {
        if (LookAt)
        {
            LocalTrans.LookAt(2 * LocalTrans.position - LookAt.position);
        }
    }
}