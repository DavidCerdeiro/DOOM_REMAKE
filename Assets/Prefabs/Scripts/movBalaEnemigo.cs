using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movBalaEnemigo : MonoBehaviour
{
    private GameObject jugador;
    public float velocidad;
    private VidaJugador vidaJugador;

    private float distancia;
    private float dificultad = Difficulty.Instance.dificultad;
    // Start is called before the first frame update
    void Start()
    {
        jugador = GameObject.FindWithTag("Player");
        velocidad = 40.0f;
        vidaJugador = jugador.GetComponent<VidaJugador>();
        distancia = 0.0f;
    }

    void Update()
    {
        float movDistancia = Time.deltaTime * velocidad;
        transform.Translate(Vector3.forward * movDistancia);
        distancia = distancia + 0.1f;
        if (distancia > 100) Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            vidaJugador.recibirDañoArmor(5.0f * dificultad);
            Destroy(gameObject);
        }
    }
}
