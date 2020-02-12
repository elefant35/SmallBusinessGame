using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegisterScript : MonoBehaviour
{
    //Private Variables
    private float moneyInRegister;
    [SerializeField] GameObject moneyPrefab;
    private bool isManned = false;
    private GameObject employeeOperating;

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
    public bool IsManned //tracks whether or not the register is manned read only to public
    {
        get { return isManned; }
        set { }
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

    public void ManRegister(GameObject Employee) //set an employee as manning the register
    {
        employeeOperating = Employee;
        isManned = true;
    }

    public void UnManRegister() //remove an employee from the register
    {
        employeeOperating = null;
        isManned = false;
    }

}
