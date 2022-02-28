using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraController : MonoBehaviour
{

    //Referencia a nuestro jugador
    public GameObject jugador;

    //Para registrar la diferencia entre la posicion de la camara y la del jugador
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {

        //Diferencia entre la posicion de la camara y la del juagdor
        offset = transform.position - jugador.transform.position;
        
    }

    // Update is called once per frame
    void LateUpdate()
    {

        //Actualizo la posicion de la camara
        transform.position = jugador.transform.position + offset;
        
    }
}
