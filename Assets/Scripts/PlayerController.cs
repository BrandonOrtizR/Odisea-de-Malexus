using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerController : MonoBehaviour
{
    public float velocidad = 10.0f;
    public float velocidadDireccion = 5.0f;
    private float horizontalInput;
    private float verticalInput;
    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Pedal");
        // Movemos el vehiculo hacia atras o hacia adelante (forward es un vector 3d = 001)
        transform.Translate(Vector3.forward * Time.deltaTime * velocidad * verticalInput);
        // Cambiamos la direccion hacia la izquierda o la derecha (up es un vector 3d = 010)
        transform.Rotate(Vector3.up * Time.deltaTime * horizontalInput * velocidadDireccion);
    }
}
