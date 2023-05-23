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
        actualizar(GameManager.Instance.municion);
    }

    // Update is called once per frame
    public void actualizar(int valor)           //Dependiendo de la cantidad de municion se pone una imagen u otra
    {
        if (valor == 0) imageComponent.sprite = imagen0;
        else if (valor == 1) imageComponent.sprite = imagen1;
        else if (valor == 2) imageComponent.sprite = imagen2;
        else if (valor == 3) imageComponent.sprite = imagen3;
        else if (valor == 4) imageComponent.sprite = imagen4;
        else if (valor < 10) imageComponent.sprite = imagen5;
        else if (valor < 15) imageComponent.sprite = imagen6;
        else imageComponent.sprite = imagen7;
    }
}
