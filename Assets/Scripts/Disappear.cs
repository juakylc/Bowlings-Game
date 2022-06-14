using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disappear : MonoBehaviour
{

    void Start()
    {
        
    }


    void Update()
    {
        // Codigo sencillo: en el momento en que se pulsa las flechas verticales, la flecha desaparece pues se ejecuta el lanzamiento
        if (Input.GetAxis("Vertical") != 0)
        {
            //Seleccionamos el gameobject arrow
            GameObject flecha = GameObject.Find("arrow");
            //y desactivamos que este activo 
            flecha.SetActive(false);
        }
    }
}
