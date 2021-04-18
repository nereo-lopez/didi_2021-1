using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    public Item item;
    public Image image;

    void Start()
    {
        if(image != null && item != null)
        {
            image.sprite = item.icon;
        }
    }

    void Update()
    {
        
    }
}
