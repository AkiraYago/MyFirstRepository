using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaPlayer : MonoBehaviour
{
    public float vidaActual;
    public float dañoBalaAObstaculos;
    public float dañoCuerpoAObtaculos;
    public VidaObjetos dañoDeObjetos;
    // Start is called before the first frame update
    void Start()
    {
        dañoDeObjetos = FindObjectOfType<VidaObjetos>();
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
            vidaActual -= dañoDeObjetos.dañoAJugador;
        }
    }
    void MuerteJugador()
    {
        if (vidaActual <= 0)
        {
            Destroy(gameObject, 0.2f);
        }
    }
}
