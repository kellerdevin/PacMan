public class MoveUpCommand : ICommand
{
    private PlayerMovement _playerMovement;

    public MoveUpCommand(PlayerMovement pm)
    {
        _playerMovement = pm;
    }

    public void Execute()
    {
        _playerMovement.MoveUp();
    }
}
