using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarPuzzle : Interactable
{
    [SerializeField] 
    private GameObject[] Objetos;
    [SerializeField] 
    private ActivarPuzzle Boton;
    [SerializeField] 
    private GameObject Esfera;
    [SerializeField] 
    public PressureSwitch Switch; 
    public Transform spawn;
    protected override void Interact()
    {
        if(Input.GetKey(KeyCode.E))
        {
            if(Boton.name == "Activar"){
                for(int i=0; i < Objetos.Length; i++)
                {
                    Objetos[i].GetComponent<Animator>().SetBool("Activado", true);
                }
            }
            if(Boton.name == "Reiniciar")
            {
                Destroy(Esfera);
                var _esfera = Instantiate(Esfera, spawn.position, spawn.rotation);
                for(int i=0; i < Objetos.Length; i++)
                {
                    Objetos[i].GetComponent<Animator>().SetBool("Activado", false);
                }
            }
        }
    }
}
