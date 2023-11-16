using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockControl : MonoBehaviour
{
    private int[] result, correctCombination;
    [SerializeField] private GameObject Puerta;
    private bool IsOpen;
    public GameObject[] Entry;
    void Start()
    {
        result =  new int[]{0,0,0};
        correctCombination = new int[] {0,6,9};
        IsOpen = false;
        Rotate.Rotated += CheckResults;
        for(int i = 0; i < Entry.Length; i++)
        {
            Entry[i].SetActive(false);
        }
    }

    public void CheckResults(string wheelName, int number)
    {
        switch (wheelName)
        {
            case "Wheel1":
                result[0] = number;
                break;
            case "Wheel2":
                result[1] = number;
                break;
            case "Wheel3":
                result[2] = number;
                break;
        }

        if(result[0] == correctCombination[0] && result[1] == correctCombination[1] && result[2] == correctCombination[2])
        {
            IsOpen = true;
            OpenDoor(IsOpen);
        }
        else
        {
            IsOpen = false;
            CloseDoor(IsOpen);
        }
    }

    private void OpenDoor(bool IsOpen)
    {
        if(IsOpen)
        {
            for(int i = 0; i < Entry.Length; i++)
            {
                Entry[i].SetActive(true);
            }
            Puerta.GetComponent<Animator>().SetBool("IsOpen", IsOpen);
        }
    }
    private void CloseDoor(bool IsOpen)
    {
        if(!IsOpen)
        {
            Puerta.GetComponent<Animator>().SetBool("IsOpen", IsOpen);
        }
    }
}
