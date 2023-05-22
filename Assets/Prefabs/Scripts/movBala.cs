using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movBala : MonoBehaviour
{
    // Start is called before the first frame update
    public float velocidad;
    public float damage;
    
    void Start()
    {
        velocidad = 10.0f;
        damage = 1.0f;
        //this.Transform.position.z = -2.25;
    }

    // Update is called once per frame
    void Update()
    {
        float movDistancia = Time.deltaTime * velocidad;
        transform.Translate(Vector3.down * movDistancia);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemigo"))
        {
            Debug.Log("he chocado con enemigo");
            other.SendMessage("tocado", damage, SendMessageOptions.DontRequireReceiver);
        }
    }
}
