using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModoEnemigo : MonoBehaviour
{
    public Animator animacion;
    float enemySpeed = 0;
    // Start is called before the first frame update
    void Start()
    {
        
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
        float distanciaJugador = Vector3.Distance(transform.position, PlayerMov.instance.Jugador.position);
        if (distanciaJugador <= 40 && distanciaJugador >= 15)
        {
            enemySpeed = 1;
            animacion.SetBool("puedeAtacar", false);
            animacion.SetBool("patrullando", false); //Desactivar patrullaje
            Debug.Log("Enemigo modo ataque");
            transform.LookAt(PlayerMov.instance.Jugador);
            transform.position = Vector3.Lerp(transform.position, PlayerMov.instance.Jugador.position, enemySpeed * Time.deltaTime);
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
