/*
 1. IDENTIFYING INFORMATION
a. Devin Keller, Kentaro Matsui, Tad Kitagushi, Miles Rovenger
b. Student ID: 2368610, 2366951, 2403661, 2343785
c. dkeller@chapman.edu, matsuo@chapman.edu, tkitaguchi@chapman.edu, rovenger@chapman.edu
d. CPSC-245
e. Final Project: PacMan
*/



using UnityEngine;

public class Move : Command
{
    private float moveDistance = 1f;
    private Vector2 direction;

    public Move(Vector3 dir)
    {
        direction = dir;
    }
    // Update Execute() method signature and implementation
    public override void Execute(GameObject gameObject)
    {
        // Move character
        gameObject.transform.Translate(direction * moveDistance);
    }
}