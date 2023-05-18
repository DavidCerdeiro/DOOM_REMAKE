using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VidaJugador : MonoBehaviour
{
    public float armorAct;
    public float vidaAct;
    public BarraVida barraVida;
    public BarraArmadura barraArmor;
    public AudioSource damageSound;
    public Image img;
    public Sprite[] caras;

    // Start is called before the first frame update
    void Start()
    {
        vidaAct = 100.0f;
        armorAct = 100.0f;
        barraVida.SetMaxHealth(200);
        barraArmor.SetMaxArmor(200);
        cambioCara(vidaAct);
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

        if (!damageSound.isPlaying && daño > 0 )
        {
            damageSound.Play();
        }
        
        if (daño < (-5.0f) && vidaAct > 100.0f) vidaAct = maximo(resguardo, 100.0f);
        cambioCara(vidaAct);
    }

    public void recibirDañoArmor(float daño)
    {

        float resguardo = armorAct;        //por si acaso es botiquin o paquete de vida

        armorAct -= daño;
        float armorFinal = maximo(armorAct, 0.0f);
        int aux = Mathf.FloorToInt(armorAct);
        barraArmor.SetArmor(aux);

        if(armorAct < 0) recibirDaño((resguardo - armorFinal) * 0.66f - armorAct);
        
        else recibirDaño((resguardo - armorFinal) * 0.66f);

        armorAct = armorFinal;
    }

    public void recibirArmor(float aux)
    {
        if (aux == 1.0f) armorAct = armorAct + aux;
        else armorAct = maximo(aux, armorAct);

        int subir = Mathf.FloorToInt(armorAct);
        barraArmor.SetArmor(subir);
    }
    public void cambioCara(float vida){
        if(vida == 100){
            img.sprite = caras[4];
        }else{
            if(vida < 75 && vida > 50){
                img.sprite = caras[2];
            }else{
                if(vida > 25 && vida < 50){
                    img.sprite = caras[2];
                }else{
                    if(vida > 0){
                        img.sprite = caras[3];
                    }else{
                        img.sprite = caras[0];
                    }
                }
            }
        }
    }


}
