using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameUIHandler : MonoBehaviour
{
    public GameObject pauseMenu;
    // Start is called before the first frame update
    void Start()
    {
        pauseMenu.SetActive(false);
    }

    public void onPauseClicked()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0;
    }

    public void onResumeClicked()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
    }

    public void onMainMenuClicked()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
