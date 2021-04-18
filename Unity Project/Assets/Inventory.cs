using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    static protected Inventory s_InventoryInstance;
    static public Inventory InventoryInstance  {get { return s_InventoryInstance; } }
    //public delegate void OnChange();
    //public OnChange();
    public int space = 8;
    public List<GameObject> items = new List<GameObject>();

    void Awake ()
    {
        s_InventoryInstance = this;
    }

    public void Add(GameObject newItem)
    {
        if (items.Count < space)
        {
            items.Add(newItem);
            //if(onChange != null)
            //{
                //onChange.Invoke();
            //}
        }
        else
        {
            Debug.Log("No hay espacio...");
        }
    }

    public void Remove(GameObject itemToRemove)
    {
        if (items.Contains(itemToRemove))
        {
            items.Remove(itemToRemove);
            //if(onChange != null)
            //{
               // onChange.Invoke();
            //}
        }
        else
        {
            Debug.Log("No hay objetos");
        }
    }
}
