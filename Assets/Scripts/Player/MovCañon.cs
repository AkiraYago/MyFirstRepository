using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovCañon : MonoBehaviour
{
    Vector3 movAtras = new Vector3(0, 0.1f, 0);
    public CrearBala tiempoEspera;
    bool canMov = true;
    // Start is called before the first frame update
    void Start()
    {
        tiempoEspera = FindObjectOfType<CrearBala>();
    }

    // Update is called once per frame
    void Update()
    {
        MovimientoCañon1();
    }
    void MovimientoCañon1()
    {
        if(Input.GetMouseButton(0))
        {
            if(canMov)
            {
                transform.Translate(-movAtras);
                Invoke("MovimientoCañon2", 0.1f);
                canMov = false;
                Invoke("Muevete", tiempoEspera.reloadTime);
            }
        }
    }
    void MovimientoCañon2()
    {
        transform.Translate(movAtras);
    }
    void Muevete()
    {
        canMov = true;
    }
}
