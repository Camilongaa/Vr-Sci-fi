using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;


public class Lights_Off : MonoBehaviour
{
    public GameObject lights;
    
    public async void OnTriggerEnter(Collider other)
    {
        lights.gameObject.SetActive(false);

        await Task.Delay(2000);
        Delete();

    }

    private void Delete()
    {
        Destroy(this.gameObject);
    }
    void Start()
    {
        lights.gameObject.SetActive(true);
    }
}
