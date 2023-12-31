using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Botón : Interactable
{
    [SerializeField]
    private GameObject Plataforma;

    [SerializeField]
    private GameObject Boton;

    [SerializeField]
    private Cañon Cañon;

    [SerializeField]
    private GameObject AnimacionCañon;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected override void Interact()
    {
        if(Input.GetKey(KeyCode.E))
        {
            if(Boton.name == "Activar Plataforma")
            {
                Plataforma.GetComponent<Animator>().speed = 1;
                Plataforma.GetComponent<Animator>().SetTrigger("Activar");
            }
            if(Boton.name == "Parar Plataforma")
            {
                Plataforma.GetComponent<Animator>().speed = 0;
            }
            if(Boton.name == "Parar Cañon")
            {
                AnimacionCañon.GetComponent<Animator>().speed = 0;
            }
            if(Boton.name == "Drop")
            {
                Plataforma.GetComponent<Animator>().speed = 1;
                Plataforma.GetComponent<Animator>().SetTrigger("Inclinar");
            }
            if(Boton.name == "Reset")
            {
                Plataforma.GetComponent<Animator>().speed = 1;
                Plataforma.GetComponent<Animator>().SetTrigger("Reset");
            }
            if(Boton.name == "Disparar")
            {
                Cañon.Disparar();
            }
            if(Boton.name == "Activar Cañon")
            {
                AnimacionCañon.GetComponent<Animator>().speed = 1;
                AnimacionCañon.GetComponent<Animator>().SetTrigger("Activar");
            }
        }
    }
}
