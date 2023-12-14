/*
 1. IDENTIFYING INFORMATION
a. Devin Keller, Kentaro Matsui, Tad Kitagushi, Miles Rovenger
b. Student ID: 2368610, 2366951, 2403661, 2343785
c. dkeller@chapman.edu, matsuo@chapman.edu, tkitaguchi@chapman.edu, rovenger@chapman.edu
d. CPSC-245
e. Final Project: PacMan
*/

using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    public int lives = 3; // Number of lives the player has
    public Transform respawnPoint; // The respawn point
    public TextMeshProUGUI livesText;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision Detected with " + collision.gameObject.name);
        if (collision.gameObject.CompareTag("Enemy"))
        {
            lives--;
            livesText.text = "Lives: " + lives;
            if (lives > 0)
            {
                Respawn();
            }
            else
            {
                Debug.Log("Game Over!");
                // Add game over logic here
                LoadLoserScene();
            }
        }
    }

    private void Respawn()
    {
        transform.position = respawnPoint.position; // Move player to respawn point
        Debug.Log("Respawned at " + respawnPoint.position);
    }
    
    private void LoadLoserScene()
    {
        SceneManager.LoadScene("LoserScene"); // Load the LoserScene
    }
}