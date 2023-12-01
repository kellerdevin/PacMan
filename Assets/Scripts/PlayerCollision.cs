using UnityEngine;
using TMPro;

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
            }
        }
    }

    private void Respawn()
    {
        transform.position = respawnPoint.position; // Move player to respawn point
        Debug.Log("Respawned at " + respawnPoint.position);
    }
}