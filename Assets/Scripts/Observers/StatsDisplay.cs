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

[RequireComponent(typeof(Text))]
public class StatsDisplay : MonoBehaviour
{
    private Text text;
    private int score;
    private int level;
    private int lives;

    private void Start()
    {
        text = GetComponent<Text>();
        score = 0;
        level = 1;
        lives = 2;
        text.text = "Score: " + score + "\nLevel: " + level + "\nLives: " + lives;
    }

    private void OnEnable()
    {  
        EatPellet.pelletEaten += UpdateScore;
        Player.playerDied += UpdateLives;
        
    }
    
    private void OnDisable()
    {
        EatPellet.pelletEaten -= UpdateScore;
        Player.playerDied -= UpdateLives;
    }
    
    private void UpdateScore()
    {
        score += 1;
        text.text = "Score: " + score + "\nLevel: " + level + "\nLives: " + lives;
        if (score >= 64)
        {
            GameController.instance.StateUpdate(GameController.GameStates.GameWon);
        }
    }
    private void UpdateLives()
    {
        if (lives > 0)
        {
            lives -= 1;
            text.text = "Score: " + score + "\nLevel: " + level + "\nLives: " + lives;
        }
        else
        {
            lives = 0;
            text.text = "Score: " + score + "\nLevel: " + level + "\nLives: " + lives + "\nGame Over";
            GameController.instance.StateUpdate(GameController.GameStates.GameLost);
        }
    }
}
