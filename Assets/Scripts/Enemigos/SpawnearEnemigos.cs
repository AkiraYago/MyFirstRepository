using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnearEnemigos : MonoBehaviour
{
    public GameObject enemigo1;
    GameObject generarEnemigo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Spawn()
    {
        generarEnemigo = Instantiate(enemigo1, transform.position, transform.rotation);
    }
}
