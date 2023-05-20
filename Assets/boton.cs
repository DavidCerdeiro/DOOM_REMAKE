using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class boton : MonoBehaviour
{
    public Button volver;
    // Start is called before the first frame update
    void Start()
    {
        volver.onClick.AddListener(LoadMenuScene);
    }
    void LoadMenuScene()
    {
        SceneManager.LoadScene("Menu");
    }
}
