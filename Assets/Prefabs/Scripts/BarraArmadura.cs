using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraArmadura : MonoBehaviour
{
    public Slider slider;
    public void SetMaxArmor(int armor){
        slider.maxValue = armor;
        slider.value = armor/2;
    }
    public void SetArmor(int armor){
        slider.value = armor;
    }
}
