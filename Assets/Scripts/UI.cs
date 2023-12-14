/*
 1. IDENTIFYING INFORMATION
a. Devin Keller, Kentaro Matsui, Tad Kitagushi, Miles Rovenger
b. Student ID: 2368610, 2366951, 2403661, 2343785
c. dkeller@chapman.edu, matsuo@chapman.edu, tkitaguchi@chapman.edu, rovenger@chapman.edu
d. CPSC-245
e. Final Project: PacMan
*/

using UnityEngine;
using UnityEngine.UI;

// The class for the UI element that displays the coins, lives, and level
public class UI : MonoBehaviour
{
    public CanvasGroup WinScreenCanvasGroup;
    // The method to update the UI
    public void Update()
    {
        ShowTime(GameTimer.GetTimeAsString());
    }
    
    public void ShowWinScreen()
    {
        CanvasGroupDisplayer.Show(WinScreenCanvasGroup);
    }
    
    public Text TimeText;
    public GameTimer GameTimer;

    public void ShowTime(string time)
    {
        TimeText.text = "Time: " + time;
    }
    public void HideWinScreen()
    {
        CanvasGroupDisplayer.Hide(WinScreenCanvasGroup);
    }
}