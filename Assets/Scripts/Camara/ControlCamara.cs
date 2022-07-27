using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCamara : MonoBehaviour
{
    public float sensibilidadCam;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RotarCamara();
    }
    void RotarCamara()
    {
        float mouseX = Input.GetAxis("Mouse X");
        if (Input.GetMouseButton(1) && mouseX != 0)
        {
            transform.Rotate(0, mouseX * sensibilidadCam * Time.deltaTime, 0);
        }
    }
}
