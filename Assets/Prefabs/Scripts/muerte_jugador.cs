using UnityEngine;
using UnityEngine.SceneManagement;

public class Muerte_jugador : MonoBehaviour
{
    public void LoadScene1()
    {
        SceneManager.LoadScene("E1M1");
    }

    public void LoadScene2()
    {
        SceneManager.LoadScene("Menu");
    }
}
