using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSwitch : MonoBehaviour
{
    [SerializeField] 
    private PuertaSinSwitch Puerta;
    [SerializeField]
    private Animator animator;

    private void OnTriggerStay(Collider other)
    {
        Puerta.AddPressureSwitch(this);
        animator.SetBool("Press", true);
    }
}
