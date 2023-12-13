using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    private ICommand moveUpCommand;
    private ICommand moveDownCommand;
    private ICommand moveLeftCommand;
    private ICommand moveRightCommand;

    // Start is called before the first frame update
    void Start()
    {
        PlayerMovement playerMovement = GetComponent<PlayerMovement>();
        
        // Initialize commands with their respective actions
        moveUpCommand = new MoveUpCommand(playerMovement);
        moveDownCommand = new MoveDownCommand(playerMovement);
        moveLeftCommand = new MoveLeftCommand(playerMovement);
        moveRightCommand = new MoveRightCommand(playerMovement);
    }

    // Update is called once per frame
    void Update()
    {
        // Check for input and execute the corresponding command
        if (Input.GetKey(KeyCode.W))
        {
            moveUpCommand.Execute();
        }
        if (Input.GetKey(KeyCode.S))
        {
            moveDownCommand.Execute();
        }
        if (Input.GetKey(KeyCode.A))
        {
            moveLeftCommand.Execute();
        }
        if (Input.GetKey(KeyCode.D))
        {
            moveRightCommand.Execute();
        }
    }
}

