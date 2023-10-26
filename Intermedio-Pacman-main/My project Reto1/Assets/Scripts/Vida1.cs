using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vida1 : MonoBehaviour
{
    public float vida;
    public float maximoVida;
    
    public GameObject gameOver; 
    
    private PersonajeController_2 player;
    private Animator animator;

    public GameObject ParticleSystem1;

    // Start is called before the first frame update
    void Start()
    {
        vida = maximoVida;   
        player = GetComponent<PersonajeController_2>();
        //animator = GetComponent<Animator>();
        

    }

   



    public void TomarVida(float dano)
    {        
        //AudioManager.Instance.PlaySFX("hit");
        vida = vida - dano;        
        
        Debug.Log("vida: " + vida);
        if(vida <= 0){

            ParticleSystem1.SetActive(true);
            Destroy(gameObject,3f);

            
            gameOver.SetActive(true);


            //AudioManager.Instance.musicSource.Stop();
            AudioManager.Instance.PlaySFX("gameOver");
            
        }
    }


    public void efectoDano(Vector2 posicion, float direccion){        
        
        //animator.SetTrigger("Golpe");
        player.Rebote(posicion, direccion);
    }

    







}
