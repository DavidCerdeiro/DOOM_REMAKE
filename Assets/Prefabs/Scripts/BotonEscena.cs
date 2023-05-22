using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonEscena : MonoBehaviour
{
    public GameObject jugador;
    private float distanciaObjetivo;
    private Transform hijo;
    // Start is called before the first frame update
    void Start()
    {
        distanciaObjetivo = 2.0f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.E))
        {
            float distancia = Vector3.Distance(transform.position, jugador.transform.position);
            if (distancia <= distanciaObjetivo)
            {
                Debug.Log("Paso al siguiente nivel");
                SceneManager.LoadScene("E1M2");
            }
        }
    }
}
