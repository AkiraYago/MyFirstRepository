using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaEnemigo : MonoBehaviour
{
    public float vidaEnemigo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MuerteEnemigo();
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "Bullet(Clone)")
        {
            vidaEnemigo -= DamageManager.instance.da�oBala;
        }
    }
    void MuerteEnemigo()
    {
        if (vidaEnemigo <= 0)
        {
            Destroy(gameObject);
        }
    }
}
