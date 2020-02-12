using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WalkController : MonoBehaviour
{
    [SerializeField] private Transform goal; // goal is the location where the character should go

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Public functions
    public void ChangeGoal(Transform newGoal)
    {
        goal = newGoal;
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        agent.destination = goal.position;
    }
}
