using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WalkController : MonoBehaviour
{
    [SerializeField] private Transform goal; // goal is the location where the character should go
    [SerializeField] private Vector3 previousPosition;
    [SerializeField] private float velocity;
    [SerializeField] private float velocityConst;
    [SerializeField] private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //calculates and sends velocity information to the animator
        velocity = Mathf.Sqrt(Mathf.Pow((transform.position.z - previousPosition.z ),2)+ Mathf.Pow((transform.position.x - previousPosition.x),2)) / Time.deltaTime;
        previousPosition = transform.position;
        animator.SetFloat("Speed_f", velocity / velocityConst);
    }

    //Public functions
    public void ChangeGoal(Transform newGoal)
    {
        if(newGoal.GetComponentInChildren<StationScript>() != null)
        {
            goal = newGoal.GetComponentInChildren<StationScript>().gameObject.transform;
        }
        else
        {
            goal = newGoal;
        }

        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        agent.destination = goal.position;
    }
}
