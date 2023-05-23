using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosion : MonoBehaviour
{
    public GameObject prefabObjetoNuevo;
    public AudioSource barrilSFX;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        //Evitamos que al chocar con el suelo desaparezca el objeto, para que solo lo haga con el jugador
        if (other.gameObject.tag != "mapa")
        {
            barrilSFX.Play();
            Instantiate(prefabObjetoNuevo, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
