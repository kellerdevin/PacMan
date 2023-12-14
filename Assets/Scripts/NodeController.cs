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
using UnityEngine;

public class NodeController : MonoBehaviour
{
    // Start is called before the first frame update
    public bool CanMoveRight = false;
    public bool CanMoveLeft = false;
    public bool CanMoveUp = false;
    public bool CanMoveDown = false;

    public GameObject NodeRight;
    public GameObject NodeLeft;
    public GameObject NodeUp;
    public GameObject NodeDown;
    
    public LayerMask targetLayer;

    private float raycastDistance = 1.1f;
    
    void Start()
    {
        RaycastHit2D[] HitsDown;
        HitsDown = Physics2D.RaycastAll(transform.position, -Vector2.up, raycastDistance, targetLayer);

        for (int i = 0; i < HitsDown.Length; i++)
        {
                CanMoveDown = true;
                NodeDown = HitsDown[i].collider.gameObject;
        }
        
        RaycastHit2D[] HitsUp;
        HitsUp = Physics2D.RaycastAll(transform.position, Vector2.up, raycastDistance, targetLayer);

        for (int i = 0; i < HitsUp.Length; i++)
        {
            CanMoveUp = true;
            NodeUp = HitsUp[i].collider.gameObject;
        }
        
        RaycastHit2D[] HitsRight;
        HitsRight = Physics2D.RaycastAll(transform.position, Vector2.right, raycastDistance, targetLayer);

        for (int i = 0; i < HitsRight.Length; i++)
        {
            CanMoveRight = true;
            NodeRight = HitsRight[i].collider.gameObject;
        }
        
        RaycastHit2D[] HitsLeft;
        HitsLeft = Physics2D.RaycastAll(transform.position, -Vector2.right, raycastDistance, targetLayer);

        for (int i = 0; i < HitsLeft.Length; i++)
        {
            CanMoveLeft = true;
            NodeLeft = HitsLeft[i].collider.gameObject;
        }
    }
    
    
    public GameObject GetNodeFromDirection(MovementController.EDirection direction)
    {
        switch (direction)
        {
            case MovementController.EDirection.Left:
                if (CanMoveLeft)
                    return NodeLeft;
                break;
            case MovementController.EDirection.Right:
                if (CanMoveRight)
                    return NodeRight;
                break;
            case MovementController.EDirection.Up:
                if (CanMoveUp)
                    return NodeUp;
                break;
            case MovementController.EDirection.Down:
                if (CanMoveDown)
                    return NodeDown;
                break;
            default:
                break;
        }
        return null;
    }
}
