using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WayPointsPatrol : MonoBehaviour
{
    // Start is called before the first frame update
    private NavMeshAgent navMeshAgent;
    public Transform[] waypoints;
    int m_currentpointIndex;
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        navMeshAgent.SetDestination(waypoints[0].position);
    }

    // Update is called once per frame
    void Update()
    {
        if(navMeshAgent.remainingDistance<navMeshAgent.stoppingDistance)
        {
            m_currentpointIndex = (m_currentpointIndex + 1) % waypoints.Length;
            navMeshAgent.SetDestination(waypoints[m_currentpointIndex].position);
        }
    }
}
