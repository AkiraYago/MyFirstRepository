using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMov : MonoBehaviour
{
    public static PlayerMov instance;
    public float velocidad;
    public float sensibilidad;
    public Rigidbody rBJugador;
    public Transform Jugador; //obtener componente en el modo enemigo
    void Start()
    {
        instance = this;
    }
    void FixedUpdate()
    {
        Movimiento();
        //Agregar Sprint?
    }
    void Movimiento()//Investigar sobre TransformDirection
    {
        float ver = Input.GetAxis("Vertical");
        float hor = Input.GetAxis("Horizontal");
        Vector3 desplazamiento = new Vector3(hor, 0, ver);
        Vector3 moveVector = transform.TransformDirection(desplazamiento) * velocidad;
        rBJugador.velocity = new Vector3(moveVector.x, rBJugador.velocity.y, moveVector.z);
        //transform.Translate(new Vector3(hor, 0, ver) * velocidad * Time.deltaTime);
    }
}
