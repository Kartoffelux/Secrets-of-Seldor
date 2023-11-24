using System.Collections;
using UnityEngine;

public class ProximidadSparrow : MonoBehaviour
{
    [SerializeField] private GameObject PuntoDialogo, CapsulaDialogo;

    private bool isPlayerInRange;

    private void OnTriggerEnter(Collider collision){
        
        if(collision.gameObject.CompareTag("Player")){
            isPlayerInRange = true;
            PuntoDialogo.SetActive(true);
            CapsulaDialogo.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider collision){
        if(collision.gameObject.CompareTag("Player")){
            isPlayerInRange = false;
            PuntoDialogo.SetActive(false);
            CapsulaDialogo.SetActive(false);
        }
    }
}