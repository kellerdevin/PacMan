using System;

public static class Game
{
    private static GameTimer GameTimer;
    
    public static void Initialize(GameTimer gameTimer)
    {
        GameTimer = gameTimer;
    }
    public static void StartGame()
    {
        GameTimer.StartTimer(90);
    }
}
