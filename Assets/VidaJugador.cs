using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaJugador : MonoBehaviour
{
    public int vidaMax = 200;
    public int vidaAct;
    public BarraVida barraVida;
    // Start is called before the first frame update
    void Start()
    {
        vidaAct = 100;
        barraVida.SetMaxHealth(vidaMax);
    }

    // Update is called once per frame
    void Update()
    {
        //Aqui ira los daños
    }
    void recibirDaño(int daño){
        vidaAct -= daño;
        barraVida.SetHealth(vidaAct);
    }
}
