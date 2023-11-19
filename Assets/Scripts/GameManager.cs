using UnityEngine;
using System;

public class GameManager : MonoBehaviour
{
    public GameTimer GameTimer;
    public Sounds Sounds;

    // Start is called before the first frame update
    void Awake()
    {
        Game.Initialize(GameTimer);
        StartGame();
        Sounds.PlayBackgroundMusic();
    }

    public void StartGame()
    {
        Game.StartGame();
    }
}

