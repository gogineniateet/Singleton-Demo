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
        goalPoints = GameObject.FindGameObjectsWithTag("Goal");
        navMeshAgent = GetComponent<NavMeshAgent>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (navMeshAgent.remainingDistance < 1.0f)
        {
            GotoLocation();
        }
        
        foreach (GameObject item in GameManager.Instance.TranshCan)
        {
            float tempDistance = Vector3.Distance(this.transform.position, item.transform.position); 
            if(tempDistance <5f && Random.Range(0,20)<5)
            {
                navMeshAgent.SetDestination(lastPoint);
                //Debug.Log(tempDistance);
            }
            else if (tempDistance > 5)
            {
                GameManager.Instance.RemoveTrashCans(item);
            }
        }
    }

    private void GotoLocation()
    {
        lastPoint = navMeshAgent.destination;//reached the 
        navMeshAgent.SetDestination(goalPoints[Random.Range(0,goalPoints.Length)].transform.position);
        
    }
}
