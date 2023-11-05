using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonesCañon : Interactable
{
    [SerializeField]
    private GameObject Boton;

    [SerializeField]
    private Cañon Cañon;

    [SerializeField]
    private GameObject AnimacionCañon;

    protected override void Interact()
    {
       if(Input.GetKey(KeyCode.E))
        {
            if(Boton.name == "Parar")
            {
                AnimacionCañon.GetComponent<Animator>().speed = 0;
            }
            if(Boton.name == "Disparar")
            {
                Cañon.Disparar();
            }
            if(Boton.name == "Activar")
            {
                AnimacionCañon.GetComponent<Animator>().speed = 1;
                AnimacionCañon.GetComponent<Animator>().SetTrigger("Activar");
            }
        }
    }
    
        
}
