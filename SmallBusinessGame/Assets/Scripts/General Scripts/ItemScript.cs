using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemScript : MonoBehaviour
{
    //Private Variables
    [SerializeField] private string itemType;
    [SerializeField] private string itemName;
    [SerializeField] private float itemValue;
    //Public Variables
    public string ItemType{
        get { return itemType; }
        set { }
    }
    public string ItemName {
        get { return itemName; }
        set { }
    }
    public float ItemValue
    {
        get { return ItemValue; }
        set { itemValue = value; } //needs to be able to be set by the register when pulling money out
    }

    //public functions
    public void deleteItem()
    {
        Destroy(gameObject);
    }
}
