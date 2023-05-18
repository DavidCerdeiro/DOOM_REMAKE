using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class add_armor : MonoBehaviour
{
    public VidaJugador vidaJugador;
    public Text tarmor;
    public Text tmarmor;
    //Con esta función vamos a controlar el aumento de la armadura del jugador
    void OnTriggerEnter(Collider other) {
    if (other.gameObject.CompareTag("armadura_verde")){
        //Mensaje original del juego al coger esta armadura
        tarmor.gameObject.SetActive(true);
        vidaJugador.recibirArmor(100.0f);
        StartCoroutine(desactiva_armor());

     }
    if (other.gameObject.CompareTag("armadura_azul")){
        //Mensaje original del juego al coger esta armadura
        Debug.Log("Picked up the megaarmor!");
        tmarmor.gameObject.SetActive(true);
        vidaJugador.recibirArmor(200.0f);
        StartCoroutine(desactiva_megaarmor());
    }
    if (other.gameObject.CompareTag("armor_bonus")){
        vidaJugador.recibirArmor(1.0f);
    }
    if (other.gameObject.CompareTag("Fire"))
    {
        //Mensaje original del juego al coger esta armadura
        Debug.Log("Te ha dado una explosion");
        vidaJugador.recibirDañoArmor(35.0f);
    }
    }
    IEnumerator desactiva_armor(){
        yield return new WaitForSeconds(3);
        tarmor.gameObject.SetActive(false);
    }
    IEnumerator desactiva_megaarmor(){
        yield return new WaitForSeconds(3);
        tmarmor.gameObject.SetActive(false);
    }
}
