using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaPlayer : MonoBehaviour
{
    public float vidaActual;
    public float da�oBalaAObstaculos; //puedo eliminar esto? si
    public float da�oCuerpoAObtaculos; //puedo eliminar esto? si 
    public VidaObjetos da�oDeObjetos; //puedo eliminar esto? si
    // Start is called before the first frame update
    void Start()
    {
        da�oDeObjetos = FindObjectOfType<VidaObjetos>();//borrar
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
            //vidaActual -= da�oDeObjetos.da�oAJugador;//cambiar
            vidaActual -= DamageManager.instance.da�oObstaculos;
        }
        else if (collision.collider.name == "Enemigo1(Clone)")
        {
            vidaActual -= DamageManager.instance.da�oEnemigo1;
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
