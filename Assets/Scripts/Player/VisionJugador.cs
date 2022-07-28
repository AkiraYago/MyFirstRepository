using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisionJugador : MonoBehaviour
{
    public Transform tarjet;
    public Camera mainCamera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Apuntar();
        Raycast();
    }
    void Apuntar()
    {
        transform.LookAt(tarjet);
    }
    void Raycast()
    {
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit raycastHit))
        {
            tarjet.position = raycastHit.point;
            Debug.DrawRay(transform.position, transform.forward * 1000, Color.red);
        }
        tarjet.position = new Vector3(tarjet.position.x, 3, tarjet.position.z);
    }
}
