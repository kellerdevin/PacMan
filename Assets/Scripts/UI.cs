using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public Text TimeText;
    public GameTimer GameTimer;

    public void Update()
    {
        ShowTime(GameTimer.GetTimeAsString());
    }

    public void ShowTime(string time)
    {
        TimeText.text = "Time: " + time;
    }
}
