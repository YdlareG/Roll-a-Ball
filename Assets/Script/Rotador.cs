using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotador : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //Rota el elememto una cantidad diferente en cada direccion y encada intervalo de tiempo
        transform.Rotate(new Vector3(15,30,45) * Time.deltaTime);
        
    }
}
