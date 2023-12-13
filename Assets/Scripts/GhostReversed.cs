using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostReversed : GhostBehavior
{
    public SpriteRenderer ghost;
    public SpriteRenderer reverseCollectable;
    public bool eaten { get; private set; }
    
    public void Eaten()
    {
        eaten = true;
        Destroy(ghost.gameObject);
    }
    
    public void OnEnable()
    {
        reverseCollectable.enabled = true;
        ghost.enabled = false;
        eaten = false;
    }
    
    public void OnDisable()
    {
        reverseCollectable.enabled = false;
        ghost.enabled = true;
        eaten = false;
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            if (enabled) //if the ghost is reversed
            {
                Eaten();
            }
        }
    }
}
