using UnityEngine;
using UnityEngine.UI;

// The class for the UI element that displays the coins, lives, and level
public class UI : MonoBehaviour
{
    // The method to update the UI
    public void Update()
    {
        ShowTime(GameTimer.GetTimeAsString());
    }
    
    public Text TimeText;
    public GameTimer GameTimer;

    public void ShowTime(string time)
    {
        TimeText.text = "Time: " + time;
    }
}