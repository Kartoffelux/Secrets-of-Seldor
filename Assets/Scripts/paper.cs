using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paper : Interactable
{
    public GameObject papel;
    public PlayerLook Look;
    public PlayerMotor Motor;
    public bool isOpen;
    // Start is called before the first frame update
    void Start()
    {
        papel.SetActive(false);
    }

    protected override void Interact()
    {
        if(Input.GetKey(KeyCode.E))
        {
            if(isOpen)
            {
                MostrarPapel();
            }
            else
            {
                CerrarPapel();
            }
        }
    }

    private void MostrarPapel()
    {
        papel.SetActive(true);
        Look.xSensitivity = 0;
        Look.ySensitivity = 0;
        Motor.speed = 0;
        isOpen = false;
    }

    private void CerrarPapel()
    {
        papel.SetActive(false);
        Look.xSensitivity = 10;
        Look.ySensitivity = 10;
        Motor.speed = 5;
        isOpen = true;
    }
}
