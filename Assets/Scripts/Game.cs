using System;


public static class Game
{
    public static UI UI;
    private static GameTimer GameTimer;
    
    
    public static void Initialize(GameTimer gameTimer, UI ui)
    {
        GameTimer = gameTimer;
        UI = ui;
    }
    public static void StartGame()
    {
        UI.HideWinScreen();
        GameTimer.StartTimer(90);
    }
    public static void EndGame()
    {
        GameTimer.StopTimer();
    }
    public static void WinGame()
    {
        GameTimer.StopTimer();
        UI.ShowWinScreen();
    }
}
