using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class botones : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(Espera());
    }
    //Función de espera de 3 segundos, después nos devuelve al menú principal
    private IEnumerator Espera()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Menu");
    }
}
