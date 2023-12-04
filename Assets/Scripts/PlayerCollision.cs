using UnityEngine;
using TMPro;

public class PlayerCollision : MonoBehaviour
{
    public int lives = 3; // Number of lives the player has

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision Detected with " + collision.gameObject.name);
        if (collision.gameObject.CompareTag("Enemy"))
        {
            lives--;
            Debug.Log("Lives left: " + lives);
            if (lives <= 0)
            {
                Debug.Log("Game Over!");
                // Add game over logic here
            }
        }
    }
    
}
