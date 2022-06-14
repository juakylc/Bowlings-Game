using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoFisico : MonoBehaviour
{
    public float forceValue;
    public float movEnLateral;
    private Rigidbody rb;
    private Vector3 posicion;
    private GameObject bola;

    
    void Start()
    {
        //Instanciamos el rigidbody, el gameobject bola, la posicion inicial de la bola (bola es el contenedor que tiene a la esfera y a la flecha)
        rb = GetComponent<Rigidbody>();
        bola = GameObject.Find("Bola");
        posicion = bola.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        //Si esta en la posicion inicial
        if (bola.transform.position.Equals(posicion))
        {
            //se le aplica la fuerza relativa de impulso vertical.
            rb.AddRelativeForce((new Vector3(0, 0, Input.GetAxis("Vertical"))) * forceValue,ForceMode.Impulse);
            //Movemos un poco tambien el contenedor bola para que los otros scripts reciban esta informacion (ya que este script lo he desarrollado a posteriori del resto del juego)
            bola.transform.Translate(0,0, Input.GetAxis("Vertical"));
        }
        //Si llega al final, deja de andar
        else if (transform.position.z > 30.5)
        {
            
        }
        //Si cae a los lados, la fuerza ya no es relativa y es en direccion hacia adelante
        else if (transform.position.x > 5.5 || transform.position.x < -5.5)
        {
            rb.AddForce((new Vector3(0, 0, 1)) * movEnLateral);
        } else
        {

        }
    }
}
