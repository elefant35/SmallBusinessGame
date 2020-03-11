using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemScript : MonoBehaviour
{
    //Private Variables
    [SerializeField] private int itemType;
    [SerializeField] private string itemName;
    [SerializeField] private float itemValue;
    //Public Variables
    bool canBePickedUp;
    public int ItemType{
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

    public bool setItemValues(int itemTypeToSet, float itemValueToSet)
    {

        if (itemTypeToSet == 1)
        {
            itemName = "Test Item 1"; // this needs to be set manually for each item to ensure the item name is consistant for the itemType
        }
        else if (itemTypeToSet == 2)
        {
            itemName = "Test Item 2";
        }
        else
        {
            return false;
        }
        itemType = itemTypeToSet;
        itemValue = itemValueToSet;
        return true;

    }


    private ItemScript cloneItemScript()
    {
        ItemScript clonedItem = new ItemScript();
        if (clonedItem.setItemValues(ItemType, ItemValue))
        {
            return clonedItem;
        }
        else
        {
            return null;
        }

    }

    public ItemScript pickUpItem()
    {
        ItemScript itemToReturn = cloneItemScript();
        Destroy(gameObject);
        return itemToReturn;
    }
}
