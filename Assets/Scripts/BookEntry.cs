using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookEntry : MonoBehaviour
{
    public GameObject[] Entry;
    public float time = 5;
    public GameObject Mensaje;
    void Start()
    {
        for(int i = 0; i < Entry.Length; i++)
        {
            Entry[i].SetActive(false);
        }
        Mensaje.SetActive(false);
        
    }
    private void OnTriggerStay(Collider other)
    {
        for(int i = 0; i < Entry.Length; i++)
        {
            Entry[i].SetActive(true);
        }
        for(int i = 0; i < time; i++)
        {
            if(i == 0)
            {
                Mensaje.SetActive(true);
            }
        }
        Mensaje.SetActive(false);
    }

}
