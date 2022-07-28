using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastEnemigo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        VisionEnemigo();
    }
    void VisionEnemigo()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            Debug.DrawRay(transform.position, transform.forward * 100, Color.green);
        }
    }
}
