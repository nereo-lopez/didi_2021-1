using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public bool isInsideZone = false;
    public KeyCode interactionKey = KeyCode.P;

    void update()
    {
        if (isInsideZone && Input.GetKeyDown(interactionKey))
        {
            Interact();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(!other.CompareTag("Player"))
        {
            return;
        }
        Debug.Log("Entra en el area");
        isInsideZone = true;
        
    }

    void OnTriggerExit(Collider other)
    {
        if(!other.CompareTag("Player"))
        {
            return;
        }
        Debug.Log("Salio en el area");
        isInsideZone = false;
    }

    public virtual void Interact()
    {

    }
}
