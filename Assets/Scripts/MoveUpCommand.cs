/*
 1. IDENTIFYING INFORMATION
a. Devin Keller, Kentaro Matsui, Tad Kitagushi, Miles Rovenger
b. Student ID: 2368610, 2366951, 2403661, 2343785
c. dkeller@chapman.edu, matsuo@chapman.edu, tkitaguchi@chapman.edu, rovenger@chapman.edu
d. CPSC-245
e. Final Project: PacMan
*/

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
