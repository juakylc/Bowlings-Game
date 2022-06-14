using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reiniciar : MonoBehaviour
{
    Scene scene;

    void Start()
    {
        // Seleccionamos la scene que esta activa
        scene = SceneManager.GetActiveScene();
    }

    
    void Update()
    {
        //Si pulsamos la tecla R
        if (Input.GetKeyDown(KeyCode.R))
        {
            //La volvemos a cargar para que se reinicie
            SceneManager.LoadScene(scene.name);
        }
            
    }
}
