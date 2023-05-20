using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class imagenMuni : MonoBehaviour
{
    public Sprite imagen0;
    public Sprite imagen1;
    public Sprite imagen2;
    public Sprite imagen3;
    public Sprite imagen4;

    private Image imageComponent;
    // Start is called before the first frame update
    void Start()
    {
        imageComponent = GetComponent<Image>();
        actualizar(0);
    }

    // Update is called once per frame
    public void actualizar(int valor)
    {
        switch (valor)
        {
            case 0:
                imageComponent.sprite = imagen0;
                break;
            case 1:
                imageComponent.sprite = imagen1;
                break;
            case 2:
                imageComponent.sprite = imagen2;
                break;
            case 3:
                imageComponent.sprite = imagen3;
                break;
            case 4:
                imageComponent.sprite = imagen4;
                break;
            default:
                // Asignar un sprite por defecto o manejar otro caso
                break;
        }
    }
}
