/*
 1. IDENTIFYING INFORMATION
a. Devin Keller, Kentaro Matsui, Tad Kitagushi, Miles Rovenger
b. Student ID: 2368610, 2366951, 2403661, 2343785
c. dkeller@chapman.edu, matsuo@chapman.edu, tkitaguchi@chapman.edu, rovenger@chapman.edu
d. CPSC-245
e. Final Project: PacMan
*/

using UnityEngine;
using System;

public class GameManager : MonoBehaviour
{
    public GameTimer GameTimer;
    public Sounds Sounds;
    public UI UI;

    // Start is called before the first frame update
    void Awake()
    {
        Game.Initialize(GameTimer, UI);
        StartGame();
        Sounds.PlayBackgroundMusic();
    }

    public void StartGame()
    {
        Game.StartGame();
    }
    public void EndGame()
    {
        Game.EndGame();
    }
    public void WinGame()
    {
        Game.WinGame();
    }
}

