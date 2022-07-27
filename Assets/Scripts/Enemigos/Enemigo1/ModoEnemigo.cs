using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModoEnemigo : MonoBehaviour
{
    //Si el jugador choca con el enemigo el enemigo se queda congelado
    public Tarjet transformJugador; //Cambiar nombre por perseguir a
    public Animator animacion;
    float enemySpeed = 0;
    // Start is called before the first frame update
    void Start()
    {
        transformJugador = FindObjectOfType<Tarjet>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, 5, transform.position.z);
        Modos();
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Bullet(Clone)")
        {
            Debug.Log("Disparaste a enemigo");
        }
    }
    void Modos()
    {
        float distanciaJugador = Vector3.Distance(transform.position, transformJugador.rotacionJugador.position);
        if (distanciaJugador <= 40 && distanciaJugador >= 15)
        {
            enemySpeed = 1;
            animacion.SetBool("puedeAtacar", false);
            animacion.SetBool("patrullando", false); //Desactivar patrullaje
            Debug.Log("Enemigo modo ataque");
            transform.LookAt(transformJugador.rotacionJugador);
            transform.position = Vector3.Lerp(transform.position, transformJugador.rotacionJugador.position, enemySpeed * Time.deltaTime);
            /*if (distanciaJugador <= 5)
            {
                enemySpeed = 0;
                animacion.SetBool("puedeAtacar", true);
                //Ejecutar animacion de ataque y lo de arriba dara problemas
            }
            else
            {
                enemySpeed = 1;
                animacion.SetBool("puedeAtacar", false);//ERROR SE ACTIVA EL MODO NEUTRAL
            }*/
        }
        else if (distanciaJugador < 15)
        {
            enemySpeed = 0;
            animacion.SetBool("puedeAtacar", true);
        }
        else
        {
            animacion.SetBool("patrullando", true);
            Debug.Log("Enemigo modo neutral");
        }
    }
}
