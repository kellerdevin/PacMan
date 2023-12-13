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
