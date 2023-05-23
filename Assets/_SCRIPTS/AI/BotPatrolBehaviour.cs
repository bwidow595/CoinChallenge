
using UnityEngine;
using UnityEngine.AI;

public class BotPatrolBehaviour : MonoBehaviour
{
    private NavMeshAgent agent;
    public Transform[] waypoints;
    private int currentWaypointInt;


    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        GetWaypoints();
    }

    void GetWaypoints()
    {
        
        currentWaypointInt = -1;
        SetNextWaypoint();
    }

    void Update()
    {
        if (agent.remainingDistance <= agent.stoppingDistance)
        {
            SetNextWaypoint();
        }
    }

    void SetNextWaypoint()
    {
        currentWaypointInt += 1;
        if (currentWaypointInt >= waypoints.Length)
        {
            currentWaypointInt = 0;
        }

        agent.SetDestination(waypoints[currentWaypointInt].position);
    }
}
