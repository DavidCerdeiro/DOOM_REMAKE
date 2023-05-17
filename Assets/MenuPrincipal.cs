using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPrincipal : MonoBehaviour
{
    public AudioSource seleccionar;
    // Start is called before the first frame update

    public void StartGame() 
    {
        seleccionar.Play();
    }

    public void Salir()
    {
        seleccionar.Play();
    }
}
