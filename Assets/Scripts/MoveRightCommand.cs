public class MoveRightCommand : ICommand
{
    private PlayerMovement playerMovement;

    public MoveRightCommand(PlayerMovement pm)
    {
        playerMovement = pm;
    }

    public void Execute()
    {
        playerMovement.MoveRight();
    }
}
