/*
 1. IDENTIFYING INFORMATION
a. Devin Keller, Kentaro Matsui, Tad Kitagushi, Miles Rovenger
b. Student ID: 2368610, 2366951, 2403661, 2343785
c. dkeller@chapman.edu, matsuo@chapman.edu, tkitaguchi@chapman.edu, rovenger@chapman.edu
d. CPSC-245
e. Final Project: PacMan
*/

using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    public GameObject StartingNode;
    public GameObject CurrentNode;
    public float speed = 4f;

    public enum EDirection
    {
        None,
        Up,
        Down,
        Left,
        Right
    }

    public EDirection Direction;
    public EDirection lastMovingDirection;

    public bool IsGhost;

    // Update is called once per frame
    void Update()
    {
        NodeController nodeController = CurrentNode.GetComponent<NodeController>();

        transform.position =
            Vector2.MoveTowards(transform.position, CurrentNode.transform.position, speed * Time.deltaTime);

        bool reverseDirection = false;
        if ((Direction == EDirection.Left && lastMovingDirection == EDirection.Right)
            || (Direction == EDirection.Right && lastMovingDirection == EDirection.Left)
            || (Direction == EDirection.Up && lastMovingDirection == EDirection.Down)
            || (Direction == EDirection.Down && lastMovingDirection == EDirection.Up)
           )
        {
            reverseDirection = true;
        }

        if (transform.position.x == CurrentNode.transform.position.x &&
            transform.position.y == CurrentNode.transform.position.y || reverseDirection)

{
            if (IsGhost)
            {
                GetComponent<EnemyNavigation>().ReachedCenterOfNode(nodeController);
            }
            
            GameObject newNode = nodeController.GetNodeFromDirection(Direction);
            
            if (!newNode.IsUnityNull())
            {
                Debug.Log("going");
                CurrentNode = newNode;
                lastMovingDirection = Direction;
            }
            else
            {
                Direction = lastMovingDirection;
                newNode = nodeController.GetNodeFromDirection(Direction);
                if (newNode)
                {
                    CurrentNode = newNode;
                }
            }
        }
        
    }

    public void SetDirection(EDirection newDirection)
    {
        Direction = newDirection;
    }
}
