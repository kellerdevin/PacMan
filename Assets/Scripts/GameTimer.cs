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
using UnityEngine;

public class GameTimer : MonoBehaviour
{
    private bool isStopped = true;
    private int timeRemaining;

    public void StartTimer(int durationInSeconds)
    {
        if (isStopped)
        {
            isStopped = false;
            timeRemaining = durationInSeconds;
            StartCoroutine(TickOneSecond());
        }
    }

    public void StopTimer()
    {
        isStopped = true;
    }

    public string GetTimeAsString()
    {
        int minutes = timeRemaining / 60;
        int seconds = timeRemaining - (minutes * 60);
        string minutesAsString = String.Format("{0:00}", minutes);
        string secondsAsString = String.Format("{0:00}", seconds);
        return minutesAsString + ":" + secondsAsString;
    }

    public bool IsRunning()
    {
        return !isStopped;
    }

    IEnumerator TickOneSecond()
    {
        yield return new WaitForSeconds(1);
        if (!isStopped)
        {
            timeRemaining = timeRemaining - 1;
            if (timeRemaining > 0)
            {
                StartCoroutine(TickOneSecond());
            }
            else
            {
                timeRemaining = 0;
                isStopped = true;
            }
        }
    }
}
