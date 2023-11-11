using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarPuzzle : Interactable
{
    [SerializeField] 
    private GameObject[] Objetos;
    [SerializeField] 
    private ActivarPuzzle Boton; 
    protected override void Interact()
    {
        if(Input.GetKey(KeyCode.E))
        {
            if(Boton.name == "Activar")
            {
                for(int i=0; i < Objetos.Length; i++)
                {
                    Objetos[i]. GetComponent<Animator>().speed = 1;
                    Objetos[i].GetComponent<Animator>().SetBool("Activado", true);
                }
            }
            if (Boton.name == "Parar")
            {
                for(int i=0; i< Objetos.Length; i++)
                {
                    Objetos[i]. GetComponent<Animator>().speed = 0;
                }
            }
            if(Boton.name == "Activar Plataforma")
            {
                for(int i=0; i < Objetos.Length; i++)
                {
                    Objetos[i]. GetComponent<Animator>().speed = 1;
                    Objetos[i].GetComponent<Animator>().SetBool("Activado", true);
                }
            }
            if(Boton.name == "Drop")
            {
                for(int i=0; i < Objetos.Length; i++)
                {
                    Objetos[i]. GetComponent<Animator>().speed = 1;
                    Objetos[i].GetComponent<Animator>().SetBool("Activado", true);
                }
            }
        }
    }
}
