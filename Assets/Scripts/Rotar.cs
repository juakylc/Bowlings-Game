using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotar : MonoBehaviour
{
    public float angularSpeed;
    private Vector3 posicion;
    private GameObject bola;

    void Start()
    {
        //Definimos el gameobject bola y la posicion inicial de bola
        bola = GameObject.Find("Bola"); 
        posicion = bola.transform.position;
    }

    
    void Update()
    {
        //Si la posicion es la inicial, no esta rotando
        if (bola.transform.position.Equals(posicion))
        {
        } 
        //Si llega al final, se para
        else if (transform.position.z > 30.5)
        {

        }
        // Si esta por los canales de los lados, rota respecto al eje x del space world ya que va hacia delante solo
        else if (transform.position.x > 5.5 || transform.position.x < -5.5)
        {
            transform.Rotate(angularSpeed * Time.deltaTime, 0, 0, Space.World);
        }
        //En los demas casos rota sobre su eje x
        else
        {
            transform.Rotate(angularSpeed * Time.deltaTime, 0, 0, Space.Self);
        }
    }
}
