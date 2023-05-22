using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ascensor : MonoBehaviour
{
    //Vector3(-9.39000034,9.81000042,20.0300007)
    //Inicial: Vector3(-9.39000034,-0.100000001,20.0300007)
    public GameObject jugador;
    private float distanciaObjetivo;
    private Vector3 inicio;
    private Vector3 final;
    // Start is called before the first frame update
    void Start()
    {
        distanciaObjetivo = 3.0f;
        inicio = new Vector3(-9.39000034f, -0.100000001f, 20.0300007f);
        final = new Vector3(-9.39000034f, 9.80800042f, 20.0300007f);
        transform.position = inicio;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float distancia = Vector3.Distance(transform.position, jugador.transform.position);
        if (distancia <= distanciaObjetivo)
        {
            Debug.Log("Ascensor sube");
            StartCoroutine(SubirAscensor());
        }
    }

    private IEnumerator SubirAscensor()
    {
        int i = 0;
        while (transform.position.y < final.y)
        {
            jugador.transform.position = transform.position + new Vector3(0.0f, 0.0025f, 0.0f);
            transform.position = transform.position + new Vector3(0.0f, 0.0015f, 0.0f);
            yield return new WaitForSeconds(0.0035f);
        }
        while(i < 200)
        {
            transform.position = transform.position + new Vector3(0.0f, 0.0f, -0.0015f);
        }

        transform.position = inicio;
    }
}
