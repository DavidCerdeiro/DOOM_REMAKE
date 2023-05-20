using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class botones : MonoBehaviour
{
    public Button reinicio;
    public Button menu;

    void Start()
    {
        reinicio.onClick.AddListener(LoadScene1);
        menu.onClick.AddListener(LoadMenuScene);
    }

    void LoadScene1()
    {
        SceneManager.LoadScene("E1M1");
    }

    void LoadMenuScene()
    {
        SceneManager.LoadScene("Menu");
    }
}
