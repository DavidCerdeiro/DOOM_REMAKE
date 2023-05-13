using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class add_armor : MonoBehaviour
{
    //Con esta función vamos a controlar el aumento de la armadura del jugador
    void OnTriggerEnter(Collider other) {
    if (other.gameObject.CompareTag("armadura_verde")){
        //Mensaje original del juego al coger esta armadura
        Debug.Log("You pick up the armor");
    }
    if (other.gameObject.CompareTag("armadura_azul")){
        //Mensaje original del juego al coger esta armadura
        Debug.Log("Picked up the megaarmor!");
    }
    if (other.gameObject.CompareTag("armor_bonus")){
        Debug.Log("Has pillado el bonus de armadura");
    }
    }
}
