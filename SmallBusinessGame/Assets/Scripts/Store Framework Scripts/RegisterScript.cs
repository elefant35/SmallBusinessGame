using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegisterScript : MonoBehaviour
{
    //Private Variables
    private float moneyInRegister;

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




}
