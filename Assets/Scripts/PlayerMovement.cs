using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    private MovementController movementController;
    void Start()
    {
        movementController = GetComponent<MovementController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            movementController.SetDirection(MovementController.EDirection.Up);
        }
        if (Input.GetKey(KeyCode.A))
        {
            movementController.SetDirection(MovementController.EDirection.Left);
        }
        if (Input.GetKey(KeyCode.S))
        {
            movementController.SetDirection(MovementController.EDirection.Down);
        }
        if (Input.GetKey(KeyCode.D))
        {
            movementController.SetDirection(MovementController.EDirection.Right);
        }
    }
}
