using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Potion", menuName="Inventory/Recovery")]

public class Potion : Item
{
    public float lifeAmount = 5.0f;

    public override void Use()
    {
        base.Use();
        Debug.Log($"Recuperando vida: {lifeAmount}");
    }
}
