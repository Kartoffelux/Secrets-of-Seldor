using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CortarCuerda : Interactable
{
    [SerializeField]
    private GameObject Link;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    protected override void Interact()
    {
        if(Input.GetKey(KeyCode.E))
        {
            if(Link.GetComponent<Collider>() != null)
            {
                if(Link.tag == "Link")
                {
                    Destroy(Link);
                }
            }
        }
    }
}
