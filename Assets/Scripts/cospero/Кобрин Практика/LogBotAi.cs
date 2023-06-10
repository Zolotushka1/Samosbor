using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class LogBotAi : MonoBehaviour
{
    UnityEngine.AI.NavMeshAgent agent;
    int i;
    public List<Transform> targets;

    // Start is called before the first frame update
    void Start()
    {
        agent=GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    void TargetUpdate()
    {
        i=Random.Range(0,targets.Count);
    }

    // Update is called once per frame
    void Update() 
    {
        float dist = Vector3.Distance (agent.transform.position, agent.pathEndPosition);

        if (dist <= 2f) 
        {
        
            TargetUpdate() ;
        }
        agent.SetDestination(targets [i].position) ;
    }
    
}
