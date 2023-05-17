using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Difficulty : MonoBehaviour
{
    public static Difficulty Instance;

    [SerializeField] private float dificultad;
    // Start is called before the first frame update
    private void Awake() 
    {
        if(Difficulty.Instance == null)
        {
            Difficulty.Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void seleccionarDificultad (float seleccion)
    {
        dificultad = seleccion;
    }

}
