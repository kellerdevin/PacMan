using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using System.Linq;
using UnityEngine;

public static class Game

{
    public static UI UI;
    public static GameTimer GameTimer;

    public static Sounds Sounds;

    public static bool hasWonLevel = false;

    private static bool isRunning = false;
    
    public static void Initialize(UI ui, GameTimer gameTimer)
    {

        UI = ui;
        GameTimer = gameTimer;
    }
    public static bool GameJustEnded()
    {
        if (isRunning && !GameTimer.IsRunning())
            return true;
        return false;
    }
    public static void StartGame()
    {
        hasWonLevel = false;
        isRunning = true;
        GameTimer.StartTimer(90);
    }

    public static void EndGame()
    {
        isRunning = false;
        GameTimer.StopTimer();
        Sounds.PlayGameOverClip();

    }

    public static bool IsRunning()
    {
        return isRunning;
    }

    public static void WinLevel()
    {
        isRunning = false;
        hasWonLevel = true;
        GameTimer.StopTimer();
    }
}
