using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonesSecretos : MonoBehaviour
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
                Debug.Log("Ahora se abriria la puerta");
                StartCoroutine(AbrirPuerta());
            }
        }
    }

    private IEnumerator AbrirPuerta()
    {
        int i = 0;
        hijo = gameObject.transform.GetChild(0).transform;

        while (i < 400)
        {
            hijo.position = hijo.position + new Vector3(0.0f, 0.0015f, 0.0f);
            yield return new WaitForSeconds(0.0035f);
            i++;
        }
        Destroy(gameObject);
    }
}
