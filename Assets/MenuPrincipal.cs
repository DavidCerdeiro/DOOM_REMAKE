using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    public AudioSource seleccionar;
    // Start is called before the first frame update

    public void StartGame() 
    {
        seleccionar.Play();
        SceneManager.LoadScene("E1M1");
    }

    public void Salir()
    {
        seleccionar.Play();
    }
}
