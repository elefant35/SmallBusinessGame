using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Public variables
    public Camera camera;
    public GameObject selectedEmployee; //this is used for testing for now but this may become a permanant variable

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //This section will monitor for mouse inputs then call the corresponding function for the click
        if (Input.GetMouseButtonDown(0))
        {
            leftClick();
        }
        if (Input.GetMouseButtonDown(1))
        {
            rightClick();
        }
        if (Input.GetMouseButtonDown(2)){
            middleClick();
        }

    }


    private void leftClick()
    {
        //this script runs if the player left clicks the mouse
        //this section of the code will do a raycast to figure out which object the player clicked
        RaycastHit hit;
        Ray ray = camera.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            GameObject objectClicked = hit.transform.gameObject;
            Debug.Log("player clicked " + objectClicked.name);
            //This is a script used to test moving a character to a particular goal if the player clicks it this section is used for testing but may turn into something permanent
            if(objectClicked.tag == "Goal")
            {
                selectedEmployee.GetComponent<WalkController>().ChangeGoal(objectClicked.transform);
            }

        }



    }

    private void rightClick()
    {
        //this script runs if the player right clicks the mouse
    }

    private void middleClick()
    {
        //this script runs if the player middle clicks the mouse
    }
}
