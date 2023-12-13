using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDownCommand : ICommand
{
    private PlayerMovement playerMovement;

    public MoveDownCommand(PlayerMovement pm)
    {
        playerMovement = pm;
    }

    public void Execute()
    {
        playerMovement.MoveDown();
    }
}