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

