using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{

    private Inventory _inventory;
    public GameObject panel;

    void Start()
    {
        _inventory = Inventory.InventoryInstance;
        //_inventory.onChange += UpdateUI;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.I))
        {
            panel.SetActive(!panel.activeSelf);
        }

    }

    void UpdateUI()
    {
        Debug.Log("Cambio el inventario");
    }

}
