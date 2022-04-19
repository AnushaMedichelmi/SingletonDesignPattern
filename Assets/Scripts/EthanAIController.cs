using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EthanAIController : MonoBehaviour
{
    [SerializeField]
    private GameObject[] goalPoints;
    NavMeshAgent agent;
    Vector3 lastPoint;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        goalPoints = GameObject.FindGameObjectsWithTag("Goal");
        GoToLocation();

    }

    // Update is called once per frame
    void Update()
    {
        if(agent.remainingDistance<1f)
        {
            GoToLocation();
        }
    }

    public void GoToLocation()
    {
        lastPoint = agent.destination;
        agent.SetDestination(goalPoints[Random.Range(0, goalPoints.Length)].transform.position);
    }
}
