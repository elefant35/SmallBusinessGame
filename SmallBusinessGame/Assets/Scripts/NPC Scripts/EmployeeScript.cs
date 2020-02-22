using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmployeeScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //Here I plan on using the list function of c# to store the tasks in a linear linked list. doc: https://www.geeksforgeeks.org/linked-list-implementation-in-c-sharp/

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
        public void SetTask(int typeToSet, GameObject focusToSet) //this function can be called in the employee class to set the details of the task they need to perform
        {
            taskType = typeToSet;
            taskFocus = focusToSet;
            setTaskName();
        }

        //private functions
        private void setTaskName() //taskType must be set before this is run
        {
            if(taskType == 0)
            {
                return;
            }
            if(taskType == 1)
            {
                taskName = "Test Task";
            }
            else if (taskType == 2)
            {
                taskName = "Walk";
            }
        }
    }
}
