using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    public GameObject dificultades;
    public GameObject botonesIniciales; 

    public AudioSource seleccionar;

    public void Start()
    {
        dificultades.SetActive(false);
    }

    public void StartGame() 
    {
        dificultades.SetActive(true);
        botonesIniciales.SetActive(false);
        seleccionar.Play();
    }

    public void Salir()
    {
        seleccionar.Play();
    }

    public void setDifficultyEasy()
    {
        seleccionar.Play();
        Difficulty.Instance.seleccionarDificultad(1f);
        SceneManager.LoadScene("E1M1");
    }

    public void setDifficultyMid()
    {
        seleccionar.Play();
        Difficulty.Instance.seleccionarDificultad(2f);
        SceneManager.LoadScene("E1M1");
    }

    public void setDifficultyHard()
    {
        seleccionar.Play();
        Difficulty.Instance.seleccionarDificultad(3f);
        SceneManager.LoadScene("E1M1");
    }
    public void Controles(){
        SceneManager.LoadScene("Controles");
    }
}
