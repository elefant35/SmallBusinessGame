using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmployeeScript : MonoBehaviour
{
    //private variables
    private float empMorale;
    public float empStress;

    //public variables
    public float EmpMorale
    {
        get { return empMorale; }
        set { }
    }
    public float EmpStress
    {
        get { return empStress; }
        set { }
    }

    LinkedList<Task> taskQueue = new LinkedList<Task>();

    EmployeeScript()
    {
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    //Functions to handle employee stats (morale stress etc.)

    public bool needsCheck(string nameOfStat, float passThreshold)// This function will check to see if the needs are above a particular level (useful for activities that need to pass a stress check)
    {
        if (nameOfStat == "morale")
        {
            if (empMorale >= passThreshold)
            {
                return true;
            }
            else return false;
        }
        else if (nameOfStat == "stress")
        {
            if (empStress >= passThreshold)
            {
                return true;
            }
            else return false;
        }
        else return false;
    }

    public bool increaseStat(string nameOfStat, float amountToIncrease)  // used to increase the stat(stress etc) of the employee only uses positive value (helps for programming animations and concequences later on to have separate functiosn for adding and subtracting to a skill)
    {
        amountToIncrease = Mathf.Abs(amountToIncrease);
        if(nameOfStat == "morale")
        {
            empMorale += amountToIncrease;
            return true;
        }
        else if(nameOfStat == "stress")
        {
            empStress += amountToIncrease;
            return true;
        }
        return false;
    }
    public bool decreaseStat(string nameOfStat, float amountToDecrease)  // used to decrease the stat(stress etc) of the employee only uses positive value (helps for programming animations and concequences later on to have separate functiosn for adding and subtracting to a skill)
    {
        amountToDecrease = Mathf.Abs(amountToDecrease);

        if (nameOfStat == "morale")
        {
            empMorale -= amountToDecrease;
            return true;
        }
        else if (nameOfStat == "stress")
        {
            empStress -= amountToDecrease;
            return false;
        }
        return false;
    }
    //Here I plan on using the list function of c# to store the tasks in a linear linked list. doc: https://www.geeksforgeeks.org/linked-list-implementation-in-c-sharp/

    bool addTaskToQueue(int taskType, GameObject focusOfTask)
    {
        Task task = new Task();
        if(task.SetTask(taskType, focusOfTask))
        {
            taskQueue.AddLast(task);
            return true;
        }
        else
        {
            return false;
        }
        
    }
    

    //This class will hold information about tasks that the employee has queued

    internal class Task
    {
        //public variables
        public string TaskName //this will be a display name used in the UI
        {
            get { return taskName; }
            set { }
        }
        public int TaskType //this will be the ID I use to determine what actions the employee will carry out it is not a unique identifier. Optimally this will be used to set task name
        {
            get { return taskType; }
            set { }
        }

        public GameObject TaskFocus //this will be the focus of the task at hand
        {
            get { return taskFocus; }
            set { }
        }

        //private variables
        private string taskName = "Error"; //set to error incase task name is not set before the task is displayed for user somehow (this shouldn't happen)
        private int taskType = 0;
        private GameObject taskFocus;


        //public functions
        public bool SetTask(int typeToSet, GameObject focusToSet) //this function can be called in the employee class to set the details of the task they need to perform
        {
            taskType = typeToSet;
            taskFocus = focusToSet;
            if (setTaskName())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //private functions
        private bool setTaskName() //taskType must be set before this is run. True means the function was successful, false means a task outside the range of tasks was entered
        {
            if(taskType == 0)
            {
                return false;
            }
            if(taskType == 1)
            {
                taskName = "Test Task";
                return true;
            }
            else if (taskType == 2)
            {
                taskName = "Walk";
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
