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

    public void OnGamePaused()
    {
        Time.timeScale = 0;
        gameState = GameStates.GamePaused;

    }

    public void OnGameWon()
    {
        Time.timeScale = 0;
        gameState = GameStates.GameWon;

    }

    public void OnGameLost()
    {
        Time.timeScale = 0;
        gameState = GameStates.GameLost;

    }
}
