using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : Interactable
{
    public static event Action<string, int> Rotated = delegate {};
    private int numberShown;
    private bool coroutineAllowed;

    private void Start()
    {
        numberShown = 0;
        coroutineAllowed = true;
    }

    protected override void Interact()
    {
        if(coroutineAllowed)
        {
            StartCoroutine("RotateWheel");
        }
    }

    private IEnumerator RotateWheel()
    {
        coroutineAllowed = false;
        for(int i = 0; i <= 11; i++)
        {
            transform.Rotate(0f,-3f,0f);
            yield return new WaitForSeconds(0.01f);
        }

        coroutineAllowed = true;

        numberShown +=1;

        if(numberShown > 9)
        {
            numberShown = 0;
        }

        Rotated(name, numberShown);
    }
}
