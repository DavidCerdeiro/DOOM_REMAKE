using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destruir_objeto : MonoBehaviour
{
    public AudioSource sfx;
    private void OnTriggerEnter(Collider other){
        //Evitamos que al chocar con el suelo desaparezca el objeto, para que solo lo haga con el jugador
        if (other.gameObject.tag == "Player") { 
        sfx.Play();
        Destroy(gameObject);
        }
    }
}
