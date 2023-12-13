using System;
using System.Collections.Generic;
using UnityEngine;

// The class for the character that collects coins, loses lives, and advances to the next level
public class Player : MonoBehaviour
{
    // The list of observers
    public static event Action playerDied;
    public static event Action ateReversedGhost;
    
    // The method to lose a life
    public void LoseLife()
    {
        playerDied?.Invoke();
    }
    public void AteGhost()
    {
        ateReversedGhost?.Invoke();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Pellet")
        {
            Destroy(col.gameObject);
        }
        if (col.gameObject.tag == "Enemy")
        {
            LoseLife();
            MovementController MC = gameObject.GetComponent<MovementController>();
            transform.position = MC.StartingNode.transform.position;
            MC.CurrentNode = MC.StartingNode;
            MC.Direction = MovementController.EDirection.None;
            MC.lastMovingDirection = MovementController.EDirection.None;
        }
        if (col.gameObject.tag == "ReverseCollectable")
        {
            Destroy(col.gameObject);
        }
        if (col.gameObject.tag == "EnemyReversed")
        {
            Destroy(col.gameObject);
            AteGhost();
        }
    }
}

