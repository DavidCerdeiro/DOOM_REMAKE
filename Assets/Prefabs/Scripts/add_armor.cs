using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class add_armor : MonoBehaviour
{
    public VidaJugador vidaJugador;
    //Con esta función vamos a controlar el aumento de la armadura del jugador
    void OnTriggerEnter(Collider other) {
    if (other.gameObject.CompareTag("armadura_verde")){
        //Mensaje original del juego al coger esta armadura
        Debug.Log("You pick up the armor");
        vidaJugador.recibirArmor(100.0f);
     }
    if (other.gameObject.CompareTag("armadura_azul")){
        //Mensaje original del juego al coger esta armadura
        Debug.Log("Picked up the megaarmor!");
        vidaJugador.recibirArmor(100.0f);
    }
    if (other.gameObject.CompareTag("armor_bonus")){
        Debug.Log("Has pillado el bonus de armadura");
        vidaJugador.recibirArmor(100.0f);
    }
    if (other.gameObject.CompareTag("Fire"))
    {
        //Mensaje original del juego al coger esta armadura
        Debug.Log("Te ha dado una explosion");
        vidaJugador.recibirDañoArmor(35.0f);
    }
    }
}
