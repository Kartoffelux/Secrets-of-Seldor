using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reiniciar : Interactable
{
    [SerializeField] 
    private GameObject[] ObjetosAnimados;
    [SerializeField] 
    private GameObject[] ObjetosRespawn;
    [SerializeField] 
    private GameObject[] prefab; 
    public Transform[] spawn;
    protected override void Interact()
    {
        if(Input.GetKey(KeyCode.E))
        {
            for(int i = 0; i < ObjetosRespawn.Length; i++ )
            {
                Destroy(ObjetosRespawn[i]); 
                var _objetosrespawn = Instantiate(prefab[i], spawn[i].position, spawn[i].rotation);
                ObjetosRespawn[i] = _objetosrespawn;
            }
            for(int i = 0; i < ObjetosAnimados.Length; i++)
            {
                ObjetosAnimados[i]. GetComponent<Animator>().speed = 1;
                ObjetosAnimados[i].GetComponent<Animator>().SetBool("Activado", false);
                ObjetosAnimados[i].GetComponent<Animator>().SetTrigger("Reset");
            }
        }
    }
}
