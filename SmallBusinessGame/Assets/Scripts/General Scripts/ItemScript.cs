using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemScript : MonoBehaviour
{
    //Private Variables
    [SerializeField] private string itemType;
    [SerializeField] private string itemName;
    [SerializeField] private string itemValue;
    //Public Variables
    public string ItemType{
        get { return itemType; }
        set { }
    }
    public string ItemName {
        get { return itemName; }
        set { }
    }
    public string ItemValue
    {
        get { return ItemValue; }
        set { itemValue = value; }
    }

    //public functions
    public void deleteItem()
    {
        Destroy(gameObject);
    }
}
