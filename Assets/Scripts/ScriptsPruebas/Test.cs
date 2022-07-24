using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    float rotacionCierre = 0.05f;
    float contador = 0.01f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        contador += 0.01f;
        transform.Rotate(rotacionCierre, rotacionCierre, 0);
        if (contador >= 4)
        {
            rotacionCierre = 0;
            if (rotacionCierre == 0)
            {
                rotacionCierre = -0.1f;
            }
        }
    }
}
