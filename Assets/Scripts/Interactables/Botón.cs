using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Botón : Interactable
{
    [SerializeField]
    private GameObject Plataforma;

    [SerializeField]
    private GameObject Boton;
    private bool Subir;
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
            if(Boton.name == "Subir")
            {
                Plataforma.GetComponent<Animator>().speed = 1;
                Plataforma.GetComponent<Animator>().SetTrigger("Subir");
            }
            if(Boton.name == "Bajar")
            {
                Plataforma.GetComponent<Animator>().speed = 1;
                Plataforma.GetComponent<Animator>().SetTrigger("Bajar");
            }
            if(Boton.name == "Parar")
            {
                Plataforma.GetComponent<Animator>().speed = 0;
            }
        }
    }
}
