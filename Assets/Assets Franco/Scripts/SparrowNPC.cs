using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SparrowNPC : Interactable
{
    [SerializeField] public Dialogue dialogue;

    protected override void Interact ()
    {
        dialogue.Interaction();
    }
}
