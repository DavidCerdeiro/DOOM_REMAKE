using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraArmadura : MonoBehaviour
{
    public Slider slider;
    //Mediante el valor máximo, obtenemos el actual
    public void SetMaxArmor(int armor){
        slider.maxValue = armor;
        slider.value = armor/2;
    }
    //Actualizamos la vida
    public void SetArmor(int armor){
        slider.value = armor;
    }
}
