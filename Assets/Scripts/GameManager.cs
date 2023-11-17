using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public UI UI;
    public GameTimer GameTimer;
    public Sounds Sounds;

    // Start is called before the first frame update
    void Awake()
    {
        Game.Initialize(UI, GameTimer);
        StartGame();
    }

    public void StartGame()
    {
        Game.StartGame();
        Sounds.PlayStartButtonSound();
    }
}

