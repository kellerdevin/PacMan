/*
 1. IDENTIFYING INFORMATION
a. Devin Keller, Kentaro Matsui, Tad Kitagushi, Miles Rovenger
b. Student ID: 2368610, 2366951, 2403661, 2343785
c. dkeller@chapman.edu, matsuo@chapman.edu, tkitaguchi@chapman.edu, rovenger@chapman.edu
d. CPSC-245
e. Final Project: PacMan
*/

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
