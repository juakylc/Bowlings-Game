using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lanzar : MonoBehaviour
{
    public float speed;
    private Vector3 posicion;

    void Start()
    {
        //Definimos la posicion inicial
        posicion = transform.position;
    }


    void Update()
    {
        //Si esta en la posicion inicial, nos movemos al pulsar el boton en la direccion z de los ejex locales del objeto
        if(transform.position.Equals(posicion))
        {
            transform.Translate(0, 0, Input.GetAxis("Vertical") * speed * Time.deltaTime, Space.Self);
        //Si esta en el final, se queda ya quieta
        } else if (transform.position.z > 30.5)
        {
            //transform.Translate(0, 0, 0, Space.Self);
        } 
        //Si esta en los canales laterales, va hacia adelante respecto a los ejes del space world
        else if (transform.position.x > 5.5 || transform.position.x < -5.5)
        {
            transform.Translate(0, 0, speed * Time.deltaTime, Space.World);
        } 
        // Si no, hacia adelante (z) respecto sus ejes locales
        else
        {
            transform.Translate(0, 0, speed * Time.deltaTime, Space.Self);
        }
        
    }
}
