/**
 * a. Devin Keller
b. Student ID: 2368610
c. dkeller@chapman.edu
d. CPSC-245
e. Assignment 1
 */

using UnityEngine;

public class PlayerMovement : Command
{
    private float moveDistance = 1f;
    private Vector2 direction;

    public PlayerMovement(Vector3 dir)
    {
        direction = dir;
    }
    // Update Execute() method signature and implementation
    public override void Execute(GameObject gameObject)
    {
        // Move character
        gameObject.transform.Translate(direction * moveDistance);
    }
    
    public void Respawn()
    {
        // Respawn logic
        // this.transform.position = new Vector3(0, 0, 0); // Example respawn position
        // Add invincibility time or other respawn logic here
    }
}