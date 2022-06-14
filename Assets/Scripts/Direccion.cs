using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Direccion : MonoBehaviour
{
    public float angularSpeed;
    private Vector3 posicion;

    void Start()
    {
        //Definimos la posicion inicial
        posicion = transform.position;
    }

    void Update()
    {
        //Si la posicion es igual que la inicial, se ejecuta
        if (transform.position.Equals(posicion))
        {
            //Si el angulo sale del rango permitido (por la derecha) mantenemos la posicion en 90 ya que será nuestro limite
            if (transform.rotation.eulerAngles.y > 90 && transform.rotation.eulerAngles.y < 180)
            {
                transform.Rotate(0, 90.0f - transform.rotation.eulerAngles.y, 0, Space.World);
            }
            //Si el angulo sale del rango permitido (por la izquierda) mantenemos la posicion en 270 ya que será nuestro limite
            else if (transform.rotation.eulerAngles.y > 180 && transform.rotation.eulerAngles.y < 270)
            {
                transform.Rotate(0, 270.0f - transform.rotation.eulerAngles.y, 0, Space.World);
            } 
            //Si está en el rango permitido, puedes mover la dirección de izquierda a derecha
            else
            {
                transform.Rotate(0, Input.GetAxis("Horizontal") * angularSpeed * Time.deltaTime, 0, Space.World);
            }
        }
    }

}
