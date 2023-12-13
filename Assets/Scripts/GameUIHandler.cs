using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameUIHandler : MonoBehaviour
{
    //link these up in unity for each scene
    public GameObject pauseMenu;
    public GameObject winScreen;
    public GameObject loseScreen;

    void Start()
    {
        pauseMenu.SetActive(false);
        winScreen.SetActive(false);
        loseScreen.SetActive(false);
    }

    public void onPauseClicked()
    {
        pauseMenu.SetActive(true);
        GameController.instance.StateUpdate(GameController.GameStates.GamePaused);
    }

    public void onResumeClicked()
    {
        pauseMenu.SetActive(false);
        GameController.instance.StateUpdate(GameController.GameStates.GamePlaying);
    }

    public void onMainMenuClicked()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void onRestartClicked() //reloads current scene
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }

    public void OnQuitClicked()
    {
        Application.Quit();
    }

    public void showGameWonScreen()
    {
        winScreen.SetActive(true);
    }

    public void showGameLoseScreen()
    {
        loseScreen.SetActive(true);
    }
}
