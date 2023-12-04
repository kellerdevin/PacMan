using UnityEngine;
using TMPro;

public class PlayerCollision : MonoBehaviour
{
    public int lives = 3; // Number of lives the player has
<<<<<<< HEAD
=======
    public Transform respawnPoint; // The respawn point
    public TextMeshProUGUI livesText;
>>>>>>> main

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision Detected with " + collision.gameObject.name);
        if (collision.gameObject.CompareTag("Enemy"))
        {
            lives--;
<<<<<<< HEAD
            Debug.Log("Lives left: " + lives);
            if (lives <= 0)
=======
            livesText.text = "Lives: " + lives;
            if (lives > 0)
            {
                Respawn();
            }
            else
>>>>>>> main
            {
                Debug.Log("Game Over!");
                // Add game over logic here
            }
        }
    }
    
}
