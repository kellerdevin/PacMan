using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public enum EGhostMovementState
{
    respawning,
    leftNode,
    rightNode,
    centerNode,
    startNode,
    movingNodes
}
public class EnemyNavigation : MonoBehaviour
{
    
    public EGhostMovementState GhostMovementState;
    
    
    public GameObject GhostNodeRight;
    public GameObject GhostNodeLeft;
    public GameObject GhostNodeUp;
    public GameObject GhostNodeDown;

    private MovementController _movementController;
    public GameObject StartingNode;
    

    private void Awake()
    {
        throw new NotImplementedException();
    }

    void Start()
    {
     
    }

    public void ReachedCenterOfNode(NodeController nodeController)
    {
        if (GhostMovementState == EGhostMovementState.movingNodes)
        {
            
        }

        else if (GhostMovementState == EGhostMovementState.respawning)
        {
            
        }
        
        else
        {
            if (GhostMovementState == EGhostMovementState.rightNode)
            {
                GhostMovementState = EGhostMovementState.centerNode;
                _movementController.SetDirection(MovementController.EDirection.Left);
            }
            else if (GhostMovementState == EGhostMovementState.leftNode)
            {
                GhostMovementState = EGhostMovementState.centerNode;
                _movementController.SetDirection(MovementController.EDirection.Right);
            }
            else if (GhostMovementState == EGhostMovementState.centerNode)
            {
                GhostMovementState = EGhostMovementState.startNode;
            }
            
            else if (GhostNodeDown == StartingNode)
            {
                GhostMovementState = EGhostMovementState.movingNodes;
            }
        }
    }

}  
