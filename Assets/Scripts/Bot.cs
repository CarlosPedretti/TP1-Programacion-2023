using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Bot : MonoBehaviour
{
    private GameObject playerScript;
    string nombreJugador;
    string nombreActual;
    public string nuevoNombre = "Bot";
    public TMP_Text Name;


    void Start()
    {
        playerScript = GameObject.FindGameObjectWithTag("Player");

    }

    public void Saludar()
    {
        //Hacemos un Set para modificar el nombre actual del jugador
        nombreJugador = playerScript.GetComponent<Player>().Nombre = nuevoNombre;
        Name.text = nombreActual;

        Debug.Log("Hola" + nombreActual + "Ahora te llamas :" + nuevoNombre);
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            //Hacemos un Get para obtener el nombre actual del jugador
            nombreActual = playerScript.GetComponent<Player>().Nombre;
            Saludar();
        }
    }
}