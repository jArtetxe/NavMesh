using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;

public class SimpleTargetTracking : MonoBehaviour
{
    public List<Transform> lGoals;
    private int numGoals;
    private NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        numGoals = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(agent.remainingDistance <=  agent.stoppingDistance)
        {
            agent.SetDestination(lGoals[numGoals].position);
            numGoals++;
            if(numGoals == lGoals.Count)
            {
                numGoals = 0;
            }
        }

    }
}
