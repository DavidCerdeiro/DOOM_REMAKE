using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class VidaJugador : MonoBehaviour
{
    private float armorAct;
    private float vidaAct;
    public BarraVida barraVida;
    public BarraArmadura barraArmor;
    public AudioSource damageSound;
    public Image img;
    public Sprite[] caras;
    void Start()
    {
        vidaAct = GameManager.Instance.vida;
        armorAct = GameManager.Instance.armor;
        barraVida.SetMaxHealth(200);
        barraArmor.SetMaxArmor(200);
        cambioCara(vidaAct);
        int aux = Mathf.FloorToInt(vidaAct);
        barraVida.SetHealth(aux);
        aux = Mathf.FloorToInt(armorAct);
        barraArmor.SetArmor(aux);
    }
    //Función auxiliar
    private float maximo(float x, float y)
    {
        if (x < y) x = y;
        return x;
    }
    //Gestionamos el daño directo a la salud
    public void recibirDaño(float daño){

        float resguardo = vidaAct;        //por si acaso es botiquin o paquete de vida

        vidaAct -= daño;

        if (!damageSound.isPlaying && daño > 0 )
        {
            damageSound.Play();
        }
        
        if (daño < (-5.0f) && vidaAct > 100.0f) vidaAct = maximo(resguardo, 100.0f);
        int aux = Mathf.FloorToInt(vidaAct);
        barraVida.SetHealth(aux);
        cambioCara(vidaAct);
        GameManager.Instance.armor = armorAct;
        GameManager.Instance.vida = vidaAct;
    }
    //Gestionamos el daño para la armadura
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
    //Aumentamos la armadura
    public void recibirArmor(float aux)
    {
        if (aux == 1.0f) armorAct = armorAct + aux;
        else armorAct = maximo(aux, armorAct);

        int subir = Mathf.FloorToInt(armorAct);
        barraArmor.SetArmor(subir);
        GameManager.Instance.armor = armorAct;
    }
    //Hacemos los cambios de cara según cambie la vida
    public void cambioCara(float vida){
        if(vida >= 100.0f){
            img.sprite = caras[4];
        }else{
            if(vida < 75.0f && vida > 50.0f){
                img.sprite = caras[2];
            }else{
                if(vida > 25.0f && vida < 50.0f){
                    img.sprite = caras[1];
                }else{
                    if(vida > 0.0f){
                        img.sprite = caras[3];
                    }else{
                        //Lo enviamos a la página de muerte
                        img.sprite = caras[0];
                        SceneManager.LoadScene("Muerte");  
                    }
                }
            }
        }
    }
}
