using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuertaSinSwitch : MonoBehaviour
{
    [SerializeField] private int requiredSwitchesToOpen = 1;
    private List<ButtonSwitch> currentSwitchesOpen = new();
    [SerializeField] private GameObject door;
    private bool doorOpen = false;

    public void AddPressureSwitch(ButtonSwitch currentSwitch)
    {
        if (!currentSwitchesOpen.Contains(currentSwitch))
        {
            currentSwitchesOpen.Add(currentSwitch);
        }
        TryOpen();
    }

    private void TryOpen()
    {
        if(currentSwitchesOpen.Count == requiredSwitchesToOpen)
        {
            OpenDoor();
        } 
        else if(currentSwitchesOpen.Count < requiredSwitchesToOpen)
        {
            CloseDoor();
        }
    }
    private void CloseDoor()
    {
        if(doorOpen)
        {
            door.GetComponent<Animator>().SetBool("IsOpen", !doorOpen);
        }
        doorOpen = false;
    }
    
    private void OpenDoor()
    {
        if(!doorOpen)
        {
            door.GetComponent<Animator>().SetBool("IsOpen", !doorOpen);
        }
        doorOpen = true;
    }
}
