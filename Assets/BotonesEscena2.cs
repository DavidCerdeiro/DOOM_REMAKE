using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class BotonesEscena2 : MonoBehaviour
{
    public Button reinicio;
    public Button menu;
    //Hacemos que según pulse un botón u otro cargue la escena correspondiente
    void Start()
    {
        reinicio.onClick.AddListener(CargaMapa);
        menu.onClick.AddListener(CargaMenu);
    }
    //Mapa en el que nos encontramos
    void CargaMapa()
    {
        SceneManager.LoadScene("E1M2");
    }
    //Volvemos al menú principal
    void CargaMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
