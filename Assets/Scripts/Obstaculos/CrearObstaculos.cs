using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearObstaculos : MonoBehaviour
{
    int contador = 0;
    public GameObject obstaculos, obstaculos2, obstaculos3;
    GameObject generarObstaculos;
    public int cantidadObstaculos;
    public int escalaMapa;
    public GameObject enemigo1;
    GameObject generarEnemigo;
    public int cantidadEnemigos;
    // Start is called before the first frame update
    void Start()//Cambiar la forma en que aparecen los bloques
    {
        transform.localScale = new Vector3(escalaMapa, transform.localScale.y, escalaMapa);
        SpawnearObstaculos();
        obstaculos = obstaculos2;
        SpawnearObstaculos();
        obstaculos = obstaculos3;
        SpawnearObstaculos();
        SpawnearEnemigos();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnearObstaculos()
    {
        /*float rangoX = -escalaMapa/2;
        float rangoZ = escalaMapa/2;*/
        for (contador = 0; contador < cantidadObstaculos; contador++)
        {
            float posicionRandomX = Random.Range(-escalaMapa / 2, escalaMapa / 2); 
            float posicionRandomZ = Random.Range(-escalaMapa / 2, escalaMapa / 2); 
            generarObstaculos = Instantiate(obstaculos, new Vector3(posicionRandomX, 0, posicionRandomZ), transform.rotation);
            generarObstaculos.name += contador;
        }
    }
    void SpawnearEnemigos()
    {
        for (contador = 0; contador < cantidadEnemigos; contador++)
        {
            generarEnemigo = Instantiate(enemigo1, new Vector3(Random.Range(-escalaMapa / 2, escalaMapa / 2), 0, Random.Range(-escalaMapa / 2, escalaMapa / 2)), transform.rotation);
        }
    }
}
