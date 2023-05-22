using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraArmadura : MonoBehaviour
{
    public Slider slider;
    public void SetMaxArmor(float armor){
        slider.maxValue = armor;
        slider.value = armor/2;
    }
    public void SetArmor(float armor){
        slider.value = armor;
    }
}
