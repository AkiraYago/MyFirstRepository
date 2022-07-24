using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaPlayer : MonoBehaviour
{
    public float vidaActual;
    public float da�oBalaAObstaculos;
    public float da�oCuerpoAObtaculos;
    public VidaObjetos da�oDeObjetos;
    // Start is called before the first frame update
    void Start()
    {
        da�oDeObjetos = FindObjectOfType<VidaObjetos>();
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
            vidaActual -= da�oDeObjetos.da�oAJugador;
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
