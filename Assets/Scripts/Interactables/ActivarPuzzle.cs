using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarPuzzle : Interactable
{
    [SerializeField] 
    private GameObject[] ObjetosAnimados;
    [SerializeField] 
    private ActivarPuzzle Boton;
    [SerializeField] 
    private GameObject[] ObjetosRespawn;
    [SerializeField] 
    private GameObject[] prefab; 
    public Transform[] spawn;
    protected override void Interact()
    {
        if(Input.GetKey(KeyCode.E))
        {
            if(Boton.name == "Activar"){
                for(int i=0; i < ObjetosAnimados.Length; i++)
                {
                    ObjetosAnimados[i].GetComponent<Animator>().SetBool("Activado", true);
                }
            }
            if(Boton.name == "Reiniciar")
            {
                for(int i = 0; i < ObjetosRespawn.Length; i++ )
                {
                    Destroy(ObjetosRespawn[i]); 
                    var _objetosrespawn = Instantiate(prefab[i], spawn[i].position, spawn[i].rotation);
                    ObjetosRespawn[i] = _objetosrespawn;
                }
                for(int i = 0; i < ObjetosAnimados.Length; i++)
                {
                    ObjetosAnimados[i].GetComponent<Animator>().SetBool("Activado", false);
                }
            }
        }
    }
}
