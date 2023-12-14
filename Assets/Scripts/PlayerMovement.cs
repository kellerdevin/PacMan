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

public class PlayerMovement : MonoBehaviour
{
    private MovementController movementController;

    // Start is called before the first frame update
    void Start()
    {
        movementController = GetComponent<MovementController>();
    }

    public void MoveUp()
    {
        movementController.SetDirection(MovementController.EDirection.Up);
    }

    public void MoveDown()
    {
        movementController.SetDirection(MovementController.EDirection.Down);
    }

    public void MoveLeft()
    {
        movementController.SetDirection(MovementController.EDirection.Left);
    }

    public void MoveRight()
    {
        movementController.SetDirection(MovementController.EDirection.Right);
    }
}
