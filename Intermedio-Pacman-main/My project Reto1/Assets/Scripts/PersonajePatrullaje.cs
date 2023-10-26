using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PersonajePatrullaje : MonoBehaviour
{
    [SerializeField] GameObject Enemigo;
    [SerializeField] Transform[] puntosControl;
    public float velocidad = 1;
    

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("MueveEnemigo");

    }

    IEnumerator MueveEnemigo()
    {
        int i = 1;
        Vector3 nuevaPosicion = new Vector3(puntosControl[i].position.x, Enemigo.transform.position.y, puntosControl[i].position.z);
        while (true)
        {
            while (Enemigo.transform.position != nuevaPosicion)
            {
                Enemigo.transform.position = Vector3.MoveTowards(Enemigo.transform.position, nuevaPosicion, velocidad * Time.deltaTime);
                yield return null;
            }
            yield return StartCoroutine("RotaEnemigo");
            if (i < 10) i++; else i = 0;
            nuevaPosicion = new Vector3(puntosControl[i].position.x, Enemigo.transform.position.y, puntosControl[i].position.z);

        }

    }
    IEnumerator RotaEnemigo()
    {
        yield return new WaitForSecondsRealtime(0.1F);

        for (int i = 1; i <= 90; i++)
        {
            Enemigo.transform.Rotate(0, -1, 0);
            yield return null;

        }

    }

    public void Update()
    {
       

        
    }






}








   