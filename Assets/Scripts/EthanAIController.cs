using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EthanAIController : MonoBehaviour
{
    [SerializeField]
    private GameObject[] goalPoints;
    NavMeshAgent navMeshAgent;
    Vector3 lastPoint;
    // Start is called before the first frame update
    void Start()
    {
        goalPoints = GameObject.FindGameObjectsWithTag("GoalPoint");
        navMeshAgent = GetComponent<NavMeshAgent>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (navMeshAgent.remainingDistance < 1.0f)
        {
            GotoLocation();
        }
    }

    private void GotoLocation()
    {
        lastPoint = navMeshAgent.destination;//reached the 
        navMeshAgent.SetDestination(goalPoints[Random.Range(0,goalPoints.Length)].transform.position);
    }
}
