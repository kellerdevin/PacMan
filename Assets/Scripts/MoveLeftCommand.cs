using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeftCommand : ICommand
{
    private PlayerMovement playerMovement;

    public MoveLeftCommand(PlayerMovement pm)
    {
        playerMovement = pm;
    }

    public void Execute()
    {
        playerMovement.MoveLeft();
    }
}
