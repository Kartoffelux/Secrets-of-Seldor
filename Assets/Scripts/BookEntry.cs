using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookEntry : MonoBehaviour
{
    public GameObject[] Entry;
    public float time = 2;
    public GameObject Mensaje;
    public Collider Boton;
    void Start()
    {
        for(int i = 0; i < Entry.Length; i++)
        {
            Entry[i].SetActive(false);
        }
        Mensaje.SetActive(false);
        
    }
    private void OnTriggerEnter(Collider other)
    {
        ActivarPaginas();
    }

    private void ActivarPaginas()
    {
        for(int i = 0; i < Entry.Length; i++)
        {
            Entry[i].SetActive(true);
        }
        StartCoroutine(Wait(time));
        Boton.enabled = !Boton.enabled;
    }

    private IEnumerator Wait(float time)
    {
        Debug.Log("Mostrar Mensaje: " + Mensaje);
        Mensaje.SetActive(true);
        yield return new WaitForSeconds(time);
        Mensaje.SetActive(false);
    }

}
