using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemScript : MonoBehaviour
{
    //Private Variables
    private string itemType;
    private string itemName;
    private string itemValue;
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
        set { }
    }

    //public functions
    public void deleteItem()
    {
        Destroy(gameObject);
    }
}
