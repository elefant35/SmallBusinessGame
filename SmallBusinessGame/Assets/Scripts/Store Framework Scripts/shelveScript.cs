using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shelveScript : MonoBehaviour
{
    [SerializeField] private static int totalShelfSpace; //this will determine how many item slots a shelf has
    private GameObject[] itemsOnShelf = new GameObject[totalShelfSpace]; //this is the list of items currently on the shelf
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool addObjectToShelf(GameObject itemToAdd) //adds an object to the shelf, it checks each shelf  space to see if there is room till it finds an open spot. True means the item was returned successfully 
    {
        for(int i = 0; i<totalShelfSpace; i++)
        {
            if(itemsOnShelf[i] == null)
            {
                itemsOnShelf[i] = itemToAdd;
                return true;
            }
        }
        return false;
    }

    public GameObject retrieveItemOnShelf(string itemName) //just returns item from shelf, does not remove it
    {
        for (int i = 0; i < totalShelfSpace; i++)
        {
            if (itemsOnShelf[i] != null)
            {
                if(itemsOnShelf[i].GetComponent<ItemScript>().ItemName == itemName)
                {
                    return itemsOnShelf[i];
                }
            }
        }
        return null;
    }

    public GameObject removeItemOnShelf(string itemName) //just returns item from shelf, does not remove it
    {
        for (int i = 0; i < totalShelfSpace; i++)
        {
            if (itemsOnShelf[i] != null)
            {
                if (itemsOnShelf[i].GetComponent<ItemScript>().ItemName == itemName)
                {
                    GameObject itemToReturn = itemsOnShelf[i];
                    itemsOnShelf[i] = null;
                    return itemToReturn;
                }
            }
        }
        return null;
    }

    public GameObject[] returnItemsOnShelf()
    {
        return itemsOnShelf;
    }

    public GameObject[] returnItemsOfType(string itemType) //THIS FUNCTION IS UNTESTED BUT EXPECTED TO BE CORRECT
    {
        int counter = -1;
        
        for (int i = 0; i < totalShelfSpace; i++)
        {
            if(itemsOnShelf[i].GetComponent<ItemScript>().ItemType == itemType)
            {
                counter++;
            }
        }
        if(counter >= 0)
        {
            GameObject[] itemsToReturn = new GameObject[counter + 1];
            counter = -1;
            for (int i = 0; i < totalShelfSpace; i++)
            {
                if (itemsOnShelf[i].GetComponent<ItemScript>().ItemType == itemType)
                {
                    counter++;
                    itemsToReturn[counter] = itemsOnShelf[i];
                }
            }
            return itemsToReturn;
        }
        else
        {
            return null;
        }
    }


    //TODO
    /*
     * I need to add functions to control the placement of new items on the shelf. 
     * 
     * 
     * 
     */
}
