using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressureSwitch : MonoBehaviour
{
    [SerializeField] 
    private Puerta Puerta;
    [SerializeField]
    private Animator animator;

    private void OnTriggerStay(Collider other)
    {
        Puerta.AddPressureSwitch(this);
        animator.SetBool("Press", true);
    }

    public void OnTriggerExit(Collider other)
    {
        Puerta.RemovePressureSwitch(this);
        animator.SetBool("Press", false);
    }
}
