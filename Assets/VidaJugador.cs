using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaJugador : MonoBehaviour
{
    public float vidaMax = 200.0f;
    public float vidaAct;
    public BarraVida barraVida;
    // Start is called before the first frame update
    void Start()
    {
        vidaAct = 100.0f;
        barraVida.SetMaxHealth(200);
    }

    // Update is called once per frame
    void Update()
    {
        //Aqui ira los daños
    }

    private float maximo(float x, float y)
    {
        if (x < y) x = y;
        return x;
    }

    public void recibirDaño(float daño){

        float resguardo = vidaAct;        //por si acaso es botiquin o paquete de vida

        vidaAct -= daño;
        int aux = Mathf.FloorToInt(vidaAct);
        barraVida.SetHealth(aux);

        if (daño < (-5.0f) && vidaAct > 100.0f) vidaAct = maximo(resguardo, 100.0f);
    }
}
