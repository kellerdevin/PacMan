using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public static GameController instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }


    public enum GameStates
    {
        MainMenu,
        GamePlaying,
        GamePaused,
        GameWon,
        GameLost
    };

    private GameStates gameState;

    void Start()
    {
        gameState = GameStates.MainMenu;
    }

    public void OnGamePlaying()
    {
        Time.timeScale = 1;
        gameState = GameStates.GamePlaying;
        SceneManager.LoadScene("SampleScene");

    }

    private void OnGamePaused()
    {
        Time.timeScale = 0;
        gameState = GameStates.GamePaused;

    }

    private void OnGameWon()
    {
        Time.timeScale = 0;
        gameState = GameStates.GameWon;

    }

    private void OnGameLost()
    {
        Time.timeScale = 0;
        gameState = GameStates.GameLost;

    }

    public void StateUpdate(GameStates newState)
    {
        switch (newState)
        {
            case GameStates.MainMenu:
                break;
            case GameStates.GamePlaying:
                OnGamePlaying();
                break;
            case GameStates.GamePaused:
                OnGamePaused();
                break;
            case GameStates.GameWon:
                gameState = GameStates.GameWon;
                OnGameWon();
                break;
            case GameStates.GameLost:
                gameState = GameStates.GameLost;
                OnGameLost();
                break;
        }
    }
}
