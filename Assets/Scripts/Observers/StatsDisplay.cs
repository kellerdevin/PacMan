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
        lives = 1;
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
        score += 10;
        text.text = "Score: " + score + "\nLevel: " + level + "\nLives: " + lives;
    }
    private void UpdateLives()
    {
        lives -= 1;
        text.text = "Score: " + score + "\nLevel: " + level + "\nLives: " + lives;
    }
}
