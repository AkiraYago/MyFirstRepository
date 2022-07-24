using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tarjet : MonoBehaviour
{
    public Camera mainCamera;
    public Transform rotacionJugador;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit raycastHit)) 
        {
            transform.position = raycastHit.point;
        }
        transform.position = new Vector3(transform.position.x, 3, transform.position.z);
    }
}
