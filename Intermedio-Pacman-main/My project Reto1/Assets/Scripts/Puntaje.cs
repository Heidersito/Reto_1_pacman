using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Puntaje : MonoBehaviour
{
    private float puntos;
    private TextMeshProUGUI textMesh;
    public GameObject CherryVariant;
    public GameObject MuroDestroy;
    public GameObject Ghost;





    // Start is called before the first frame update
    void Start()
    {
        textMesh = GetComponent<TextMeshProUGUI>();



    }

    // Update is called once per frame
    void Update()
    {
        textMesh.text = puntos.ToString("0");


        if (puntos >= 4)
        {
            // Obtén una referencia al componente "PersonajePatrullaje" en el mismo GameObject.
            PersonajePatrullaje personaje = GetComponent<PersonajePatrullaje>();

            if (personaje != null)
            {
                // Modifica la velocidad del personaje en el script "PersonajePatrullaje" a 7.
                personaje.velocidad = 7.0f;
            }
            else
            {
                Debug.LogError("El componente 'PersonajePatrullaje' no se encontró en este GameObject.");
            }

            if (puntos == 15)
            {
                Debug.Log("Cherry");
                CherryVariant.SetActive(true);
                Destroy(MuroDestroy);

            }




        } 
    }

        public void SumarPuntos(float puntosEntrada)
        {
            puntos += puntosEntrada;

        }









 }



    

