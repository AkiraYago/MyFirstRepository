using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovObjetos : MonoBehaviour
{
    public Vector3 direccionDeFlote;
    public Vector3 direccionDeRotacion;
    public float velocidadFlote;
    public float velocidadRotacion;
    public float alturaFlote;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direccionDeFlote * velocidadFlote * Time.deltaTime);
        transform.Rotate(direccionDeRotacion * velocidadRotacion * Time.deltaTime);
        transform.position = new Vector3(transform.position.x, alturaFlote, transform.position.z);
    }
}
