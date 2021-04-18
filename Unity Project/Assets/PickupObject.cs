using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupObject : Interactable 
{

    public Item item;

    public override void Interact()
    {
        Inventory.InventoryInstance.Add(this.gameObject);
        Destroy(this.gameObject);
    }
}
