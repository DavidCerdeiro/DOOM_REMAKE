using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraVida : MonoBehaviour
{
    public Slider slider;
    public void SetMaxHealth(int vida){
        slider.maxValue = vida;
        slider.value = vida/2;
    }
    public void SetHealth(int vida){
        slider.value = vida;
    }
}
