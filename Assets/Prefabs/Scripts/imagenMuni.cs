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
    public Sprite imagen5;
    public Sprite imagen6;
    public Sprite imagen7;

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
                {
                    if(valor > 4 && valor < 10) imageComponent.sprite = imagen5;
                    else if (valor > 9 && valor < 15) imageComponent.sprite = imagen6;
                    else imageComponent.sprite = imagen7;
                }
                // Asignar un sprite por defecto o manejar otro caso
                break;
        }
    }
}
