using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class add_salud : MonoBehaviour
{
    //Con esta función vamos a controlar el aumento de la salud del jugador
    void OnTriggerEnter(Collider other) {
    if (other.gameObject.CompareTag("pocion_azul")){
    }
    if (other.gameObject.CompareTag("paquete_salud")){
    }
    if (other.gameObject.CompareTag("botiquin")){
    }
    }
}
