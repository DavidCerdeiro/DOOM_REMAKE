using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class areaexplosion : MonoBehaviour
{
    public GameObject jugador;
    public VidaJugador vidaJugador;
    // Start is called before the first frame update
    void Start()
    {
        vidaJugador = jugador.GetComponent<VidaJugador>();
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        //Evitamos que al chocar con el suelo desaparezca el objeto, para que solo lo haga con el jugador
        if (other.gameObject.tag == "Player")
        {
            vidaJugador.recibirDaño(30.0f);
        }
    }
}
