using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuHandler : MonoBehaviour
{
    public GameObject instructionPanel;
    public GameObject mainMenuPanel;
    void Start()
    {
        instructionPanel.SetActive(false);
    }
    public void OnPlayClicked()
    {
        GameController.instance.StateUpdate(GameController.GameStates.GamePlaying);
        SceneManager.LoadScene("SampleScene");
    }

    public void OnInstructionsClicked()
    {
        mainMenuPanel.SetActive(false);
        instructionPanel.SetActive(true);
    }

    public void OnQuitClicked()
    {
        Application.Quit();
    }

    public void OnBackClicked()
    {
        mainMenuPanel.SetActive(true);
        instructionPanel.SetActive(false);
    }
}
