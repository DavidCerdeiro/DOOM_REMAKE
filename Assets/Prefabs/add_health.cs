using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class add_health : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("paquete_salud")){
            //Mensaje original del juego al coger esta armadura
            Debug.Log("PAQUETE DE SALUD");
        }
        if (other.gameObject.CompareTag("pocion_azul")){
            //Mensaje original del juego al coger esta armadura
            Debug.Log("POCION AZUL");
        }if (other.gameObject.CompareTag("botiquin")){
            //Mensaje original del juego al coger esta armadura
            Debug.Log("HAS COGIDO EL BOTIQUIN");
        }
    }
}

