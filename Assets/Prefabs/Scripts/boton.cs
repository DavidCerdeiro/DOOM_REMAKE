using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class boton : MonoBehaviour
{
    public Button volver;
    //Cuando pulse el botón volvera a la escena del menú principal
    void Start()
    {
        volver.onClick.AddListener(CargaMenu);
    }
    void CargaMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
