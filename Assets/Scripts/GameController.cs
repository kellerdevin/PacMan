using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public static GameController instance;
    private GameUIHandler currentGameUIHandler; //reference to the current game UI handler in the scene.

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            SceneManager.sceneLoaded += OnSceneLoaded;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }
    private void OnSceneLoaded(Scene scene, LoadSceneMode mode) //Finds the game UI handler in the scene and assigns it to currentGameUIHandler when a new scene is loaded(If the scene doesn't have one, will just ignore).
    {
        currentGameUIHandler = FindObjectOfType<GameUIHandler>();
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
        gameState = GameStates.MainMenu; //Game state is in main menu at start
    }

    public void OnGamePlaying() //Code to execute when game state is updated to playing
    {
        Time.timeScale = 1;
        gameState = GameStates.GamePlaying;
    }

    private void OnGamePaused() //Code to execute when game state is updated to paused
    {
        Time.timeScale = 0;
        gameState = GameStates.GamePaused;

    }

    private void OnGameWon() //Code to execute when game state is updated to won
    {
        Time.timeScale = 0;
        gameState = GameStates.GameWon;
        currentGameUIHandler?.showGameWonScreen(); //calls showGameWonScreen() from Game UI Handler

    }

    private void OnGameLost() //Code to execute when game is lost
    {
        Time.timeScale = 0;
        gameState = GameStates.GameLost;
        currentGameUIHandler?.showGameLoseScreen(); //calls showGameLoseScreen() from Game UI Handler

    }

    public void StateUpdate(GameStates newState) //call this to update game state. (call "GameController.instance.StateUpdate(GameController.GameStates.your_game_state_here);" from other scripts to change the game state)
    {
        switch (newState)
        {
            case GameStates.MainMenu:
                break;
            case GameStates.GamePlaying:
                OnGamePlaying(); //time scale set to 1
                break;
            case GameStates.GamePaused:
                OnGamePaused(); //pauses game(time scale set to 0) and shows pause menu
                break;
            case GameStates.GameWon:
                gameState = GameStates.GameWon;
                OnGameWon(); //Pauses game and shows game won screen.
                break;
            case GameStates.GameLost:
                gameState = GameStates.GameLost;
                OnGameLost(); //Pauses game and shows game lose screen.
                break;
        }
    }
}
