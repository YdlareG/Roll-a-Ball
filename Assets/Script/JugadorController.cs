using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Agregamos
using UnityEngine.UI;

public class JugadorController : MonoBehaviour
{
    //Declarlo la variable de tipo RigidBody que luego asociaremos a nuestro Jugador
    private Rigidbody rb;

    //Inicializo el contador de coleccionables recogidos
    private int contador;

    //Inicializo varibles para los textos
    public Text textoContador, textoGanar;

    //Declaro la variable publica velocidad para poder modificarla desde la inspector window
    public float velocidad;

    // Start is called before the first frame update
    void Start()
    {
        //Capturo esa variable al iniciar el juego
        rb = GetComponent<Rigidbody>();
        
        //Inicio el contador a 0
        contador = 0;

        //Actualizo el texto del contador por primera vez
        setTextoContador();

        //Inicio el texto de ganar a vacio
        textoGanar.text = "";
    }
    
    // Update is called once per frame
    void FixedUpdate()
    {
        //Estas variables nos capturan el movimiento en horizontal y vertical de nuestro teclado
        float movimientoH = Input.GetAxis("Horizontal");
        float movimientoV = Input.GetAxis("Vertical");

        //Un vector 3 es un trio de posiciones en el espacio XYZ, en este caso el que corresponde al movimiento
        Vector3 movimiento = new Vector3(movimientoH, 0.0f, movimientoV);

        //Asigno ese movimiento o desplazamiento a mi RigidBody, multiplicado por la velocidad que quiera darle
        rb.AddForce(movimiento * velocidad);
    }

    //Se ejecuta al entrar a un objeto con la opcion isTrigger seleccionada
    void OnTriggerEnter(Collider other){
        if (other.gameObject.CompareTag("Coleccionable")){
            //Desactivo el objeto
            other.gameObject.SetActive(false);
            
            //Incremento el contador en uno (tambien se puede hacer como contador++)
            contador = contador + 1;

            //Actualizo el texto del contador
            setTextoContador();
        }
    }

    void setTextoContador(){

        textoContador.text = "Contador: " + contador.ToString();
        if (contador >=12){

            textoGanar.text = "¡GANASTE!";

        }
    }
}
