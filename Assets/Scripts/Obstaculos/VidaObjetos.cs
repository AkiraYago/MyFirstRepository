using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaObjetos : MonoBehaviour
{
    public float vidaActual;
    public float da�oAJugador;//borrar
    public VidaPlayer da�oDelJugador;//borrar
    // Start is called before the first frame update
    void Start()
    {
        da�oDelJugador = FindObjectOfType<VidaPlayer>();//borrar
    }

    // Update is called once per frame
    void Update()
    {
        Desaparecer();
    }
    void Desaparecer()
    {
        if (vidaActual <= 0)
        {
            Destroy(gameObject, 0.1f);
            Debug.Log("Has destruido un " + gameObject.name);
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "Jugador")
        {
            Debug.Log("El jugador esta chocando con" + gameObject.name);
            //vidaActual -= da�oDelJugador.da�oCuerpoAObtaculos;//cambiar
            vidaActual -= DamageManager.instance.da�oJugador;
        }
        else if (collision.collider.name == "Bullet(Clone)")
        {
            Debug.Log("El jugador esta disparando a " + gameObject.name);
            //vidaActual -= da�oDelJugador.da�oBalaAObstaculos;//cambiar
            vidaActual -= DamageManager.instance.da�oBala;
        }
    }
}
