/*
 1. IDENTIFYING INFORMATION
a. Devin Keller, Kentaro Matsui, Tad Kitagushi, Miles Rovenger
b. Student ID: 2368610, 2366951, 2403661, 2343785
c. dkeller@chapman.edu, matsuo@chapman.edu, tkitaguchi@chapman.edu, rovenger@chapman.edu
d. CPSC-245
e. Final Project: PacMan
*/

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : MonoBehaviour
{
    public GhostReversed ghostReversed { get; private set; }
    

    private void Awake()
    {
        ghostReversed = GetComponent<GhostReversed>();

    }

    private void Start()
    {
        ghostReversed.Disable();
        gameObject.tag = "Enemy";
    }

    private void OnEnable()
    {
        EatReverseCollectable.reverseCollectableCollected += InReverse;
    }
    
    private void OnDisable()
    {
        EatReverseCollectable.reverseCollectableCollected -= InReverse;
    }
    
    public IEnumerator ReverseCountdown(int count)
    {
        while (count > 0)
        {
            ghostReversed.OnEnable();
            gameObject.tag = "EnemyReversed";
            yield return new WaitForSeconds(1);
            count--;
        }
        ghostReversed.OnDisable();
        gameObject.tag = "Enemy";
    }
    
    private void InReverse()
    {
        StartCoroutine(ReverseCountdown(6));
    }
}