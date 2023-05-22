using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movBalaEnemigo : MonoBehaviour
{
    private GameObject jugador;
    public float velocidad;
    // Start is called before the first frame update
    void Start()
    {
        jugador = GameObject.FindWithTag("Player");
        velocidad = 20.0f;
    }

    void Update()
    {
        float movDistancia = Time.deltaTime * velocidad;
        transform.Translate(Vector3.forward * movDistancia);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("he chocado con el jugador");
        }
    }
}
