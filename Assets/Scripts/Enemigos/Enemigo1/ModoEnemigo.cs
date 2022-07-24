using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModoEnemigo : MonoBehaviour
{
    //Si el jugador choca con el enemigo el enemigo se queda congelado
    public Tarjet transformJugador; //Cambiar nombre por perseguir a
    public Animator animacion;
    public GameObject pupilaEnemigo;
    public GameObject brazos;
    public GameObject brazosAtack;
    float enemySpeed = 1;
    //bool atacaronAEnemigo = false;
    //public float multPosiciones;
    // Start is called before the first frame update
    void Start()
    {
        transformJugador = FindObjectOfType<Tarjet>(); //Le dare uso?
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x/* * multPosiciones*/, 5, transform.position.z/* * multPosiciones*/);
        Modos();
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Bullet(Clone)")
        {
            Debug.Log("Disparaste a enemigo");
            //atacaronAEnemigo = true;
        }
    }
    void Modos()
    {
        float distanciaJugador = Vector3.Distance(transform.position, transformJugador.rotacionJugador.position);
        if (/*atacaronAEnemigo == true ||*/ distanciaJugador <= 40)
        {
            animacion.SetBool("patrullando", false); //Desactivar patrullaje
            Debug.Log("Enemigo modo ataque");
            transform.LookAt(transformJugador.rotacionJugador);
            pupilaEnemigo.SetActive(false); //Get component in children?
            brazos.SetActive(false); brazosAtack.SetActive(true);
            transform.position = Vector3.Lerp(transform.position, transformJugador.rotacionJugador.position, enemySpeed * Time.deltaTime);
            if (distanciaJugador <= 10)
            {
                enemySpeed = 0;
            }
            else
            {
                enemySpeed = 1;
            }
        }
        else
        {
            animacion.SetBool("patrullando", true);
            Debug.Log("Enemigo modo neutral");
            pupilaEnemigo.SetActive(true);
            brazos.SetActive(true); brazosAtack.SetActive(false);
        }
    }
}
