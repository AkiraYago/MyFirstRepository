using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearBala : MonoBehaviour
{
    public GameObject proyectil;
    public Transform spawnpointBala;
    GameObject generarProyectil;
    bool puedeDisparar = true;
    public float reloadTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CrearProyectil();
    }
    void CrearProyectil()
    {
        if (Input.GetMouseButton(0))
        {
            if(puedeDisparar)
            {
                generarProyectil = Instantiate(proyectil, spawnpointBala.position, spawnpointBala.rotation);
                Destroy(generarProyectil, 3f);
                puedeDisparar = false;
                Invoke("EsperarBala", reloadTime);
            }
        }
    }
    void EsperarBala()
    {
        puedeDisparar = true;
    }
}
