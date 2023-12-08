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


    public GameObject GameObjectManager;
    public PacManGameManager PacManGameManager;

    private void Awake()
    {
        _movementController = GetComponent<MovementController>();
        PacManGameManager = GameObjectManager.GetComponent<PacManGameManager>();
    }

    void Start()
    {
     
    }

    public void ReachedCenterOfNode(NodeController nodeController)
    {
        if (GhostMovementState == EGhostMovementState.movingNodes)
        {
            Debug.Log("Determining...");
            DetermineGhostDirection();
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

    public void DetermineGhostDirection()
    {
        MovementController.EDirection direction = GetSendClosestDirection(PacManGameManager.PacMan.transform.position);
        _movementController.SetDirection(direction);
    }

    MovementController.EDirection GetSendClosestDirection(Vector2 target)
    {
        float shortestDistance = 0;
        MovementController.EDirection newDirection = MovementController.EDirection.None;
        MovementController.EDirection lastMovingDirection = _movementController.lastMovingDirection;

        NodeController NC = _movementController.CurrentNode.GetComponent<NodeController>();

        if (NC.CanMoveUp && lastMovingDirection != MovementController.EDirection.Down)
        {
            GameObject node = NC.NodeUp;
            float distance = Vector2.Distance(node.transform.position, target);

            if (distance < shortestDistance || shortestDistance == 0)
            {
                shortestDistance = distance;
                newDirection = MovementController.EDirection.Up;
            }
        }
        
        if (NC.CanMoveDown && lastMovingDirection != MovementController.EDirection.Up)
        {
            GameObject node = NC.NodeDown;
            float distance = Vector2.Distance(node.transform.position, target);

            if (distance < shortestDistance || shortestDistance == 0)
            {
                shortestDistance = distance;
                newDirection = MovementController.EDirection.Down;
            }
        }
        
        if (NC.CanMoveLeft && lastMovingDirection != MovementController.EDirection.Right)
        {
            GameObject node = NC.NodeLeft;
            float distance = Vector2.Distance(node.transform.position, target);

            if (distance < shortestDistance || shortestDistance == 0)
            {
                shortestDistance = distance;
                newDirection = MovementController.EDirection.Left;
            }
        }
        
        if (NC.CanMoveRight && lastMovingDirection != MovementController.EDirection.Left)
        {
            GameObject node = NC.NodeRight;
            float distance = Vector2.Distance(node.transform.position, target);

            if (distance < shortestDistance || shortestDistance == 0)
            {
                shortestDistance = distance;
                newDirection = MovementController.EDirection.Right;
            }
        }

        return newDirection;
    }
}  
