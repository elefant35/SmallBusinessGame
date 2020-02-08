using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegisterScript : MonoBehaviour
{
    //Private Variables
    private float moneyInRegister;
    [SerializeField] GameObject moneyPrefab;

    //Public Variables
    public float MoneyInRegister //Tracks the Money currently in the register
    {
        get
        {
            return moneyInRegister;
        }
        set
        {
            moneyInRegister = value;
        }
    }


    //Public Functions
    
    public GameObject PullMoneyFromRegister(float amountOfMoney) //returns game object with money or null if there is not enough money
    {
        if (amountOfMoney <= moneyInRegister)
        {
            GameObject moneyReturned = Instantiate(moneyPrefab);
            moneyReturned.GetComponent<ItemScript>().ItemValue = amountOfMoney;
            return moneyReturned;
        }
        else return null;
    }

}
