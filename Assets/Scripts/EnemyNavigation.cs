using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyNavigation : MonoBehaviour
{
    public GameObject Player;
    private Vector3 target; 
    private NavMeshAgent agent;

    void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
        SetTargetPosition();
        SetAgentPosition();
    }

    private void Update()
    {
    }

    void SetTargetPosition()
    {
        target = Player.transform.position;
    }

    void SetAgentPosition()
    {
        NavMeshPath path = new NavMeshPath();
        agent.CalculatePath(target, path);
        for (int i = 0; i < path.corners.Length-1; i++)
            Debug.DrawLine(path.corners[i], path.corners[i+1], Color.red);
    }
    
}
