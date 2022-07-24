using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaObjetos : MonoBehaviour
{
    public float vidaActual;
    public float dañoAJugador;
    public VidaPlayer dañoDelJugador;
    // Start is called before the first frame update
    void Start()
    {
        dañoDelJugador = FindObjectOfType<VidaPlayer>();
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
            vidaActual -= dañoDelJugador.dañoCuerpoAObtaculos;
        }
        else if (collision.collider.name == "Bullet(Clone)")
        {
            Debug.Log("El jugador esta disparando a " + gameObject.name);
            vidaActual -= dañoDelJugador.dañoBalaAObstaculos;
        }
    }
}
