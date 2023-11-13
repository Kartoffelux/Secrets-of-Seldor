using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressureButtonDisappear : MonoBehaviour
{
    [SerializeField]
    private Animator[] Vidrios;

    private void OnTriggerStay(Collider other)
    {
        for(int i = 0; i < Vidrios.Length; i++)
        {
            Vidrios[i].SetTrigger("Disappear");
        }
        
    }
}
