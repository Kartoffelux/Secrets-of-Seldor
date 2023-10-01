using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    //Mensaje que aparece cuando se acerca a un objeto con el que se puede interactuar
    public string promptMessage;
    
    public void BaseInteract()
    {
        Interact();
    }
    
    protected virtual void Interact()
    {

    }
}
