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


