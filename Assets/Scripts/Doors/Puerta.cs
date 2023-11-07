using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puerta : MonoBehaviour
{
    [SerializeField] private int requiredSwitchesToOpen = 1;
    private List<PressureSwitch> currentSwitchesOpen = new();
    [SerializeField] private GameObject door;
    private bool doorOpen = false;

    public void AddPressureSwitch(PressureSwitch currentSwitch)
    {
        if (!currentSwitchesOpen.Contains(currentSwitch))
        {
            currentSwitchesOpen.Add(currentSwitch);
        }
        TryOpen();
    }
    
    public void RemovePressureSwitch(PressureSwitch currentSwitch)
    {
        if (currentSwitchesOpen.Contains(currentSwitch))
        {
            currentSwitchesOpen.Remove(currentSwitch);
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
