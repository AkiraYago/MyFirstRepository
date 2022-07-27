using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaPlayer : MonoBehaviour
{
    public float vidaActual;
    public float dañoBalaAObstaculos; //puedo eliminar esto? si
    public float dañoCuerpoAObtaculos; //puedo eliminar esto? si 
    public VidaObjetos dañoDeObjetos; //puedo eliminar esto? si
    // Start is called before the first frame update
    void Start()
    {
        dañoDeObjetos = FindObjectOfType<VidaObjetos>();//borrar
    }

    // Update is called once per frame
    void Update()
    {
        MuerteJugador();
    }
    void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Obstaculos")
        {
            //vidaActual -= dañoDeObjetos.dañoAJugador;//cambiar
            vidaActual -= DamageManager.instance.dañoObstaculos;
        }
        else if (collision.collider.name == "Enemigo1(Clone)")
        {
            vidaActual -= DamageManager.instance.dañoEnemigo1;
        }
    }
    void MuerteJugador()
    {
        if (vidaActual <= 0)
        {
            Destroy(gameObject, 0.2f);
        }
    }
    //crear funcion que baje vida al jugador (se usara cuando el jugador colisione con un obtaculo y cuando colisione con un enemigo)
}
