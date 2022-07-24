using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApuntarMouse : MonoBehaviour
{
    public Transform cubo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Apuntar();
    }
    void Apuntar()
    {
        transform.LookAt(cubo);
    }
}
