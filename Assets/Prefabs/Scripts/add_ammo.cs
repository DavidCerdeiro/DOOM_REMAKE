using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class add_ammo : MonoBehaviour
{
    public imagenMuni imagen;
    public int municion;
    void Start()
    {
        municion = GameManager.Instance.municion;
        imagen.actualizar(municion);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("municion"))
        {
            municion++;
            GameManager.Instance.municion = municion;
            imagen.actualizar(municion);
        }
    }

    public bool CogerMunicion()
    {
        if (municion > 0)
        {
            municion--;
            GameManager.Instance.municion = municion;
            imagen.actualizar(municion);
            return true;
        }
        else return false;
    }
}
