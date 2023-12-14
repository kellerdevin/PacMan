/*
 1. IDENTIFYING INFORMATION
a. Devin Keller, Kentaro Matsui, Tad Kitagushi, Miles Rovenger
b. Student ID: 2368610, 2366951, 2403661, 2343785
c. dkeller@chapman.edu, matsuo@chapman.edu, tkitaguchi@chapman.edu, rovenger@chapman.edu
d. CPSC-245
e. Final Project: PacMan
*/

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
        SceneManager.LoadScene("PacManMap"); //Put Whatever scene you want to load first here
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
