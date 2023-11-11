using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformaEvent : MonoBehaviour
{
    [SerializeField] 
    private GameObject[] Objetos;
    public void DesactivarAnimacion()
    {
        for(int i=0; i < Objetos.Length; i++)
        {
            Objetos[i].GetComponent<Animator>().SetBool("Activado", false);
        }
    }
}
