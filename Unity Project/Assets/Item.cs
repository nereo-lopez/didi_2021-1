using UnityEngine;

public enum ItemType
{
    Material, Restore, Weapon
}

[CreateAssetMenu(fileName = "New Item", menuName="Inventory/Generic")]

public class Item : ScriptableObject
{
    public ItemType itemType = ItemType.Material;
    public Sprite icon = null;
    
    public virtual void Use()
    {
        Debug.Log($"Use Item{name}");
    }
}
