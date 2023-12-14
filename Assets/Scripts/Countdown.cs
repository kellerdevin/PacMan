/*
 1. IDENTIFYING INFORMATION
a. Devin Keller, Kentaro Matsui, Tad Kitagushi, Miles Rovenger
b. Student ID: 2368610, 2366951, 2403661, 2343785
c. dkeller@chapman.edu, matsuo@chapman.edu, tkitaguchi@chapman.edu, rovenger@chapman.edu
d. CPSC-245
e. Final Project: PacMan
*/

using System.Collections;
using TMPro;
using UnityEngine;

namespace Script
{
    //coroutine class Countdown
    public class Countdown : MonoBehaviour
    {
        //TextMeshProUGUI for TextMeshPro
        public TextMeshProUGUI timeText;
        
        public IEnumerator Counter(int count)
        {
            while (count > 0)
            {
                Debug.Log(count);
                //format count to 00 digits
                timeText.text = $"{count:00}";
                yield return new WaitForSeconds(1f);
                count--;
            }
        }
    }
}


