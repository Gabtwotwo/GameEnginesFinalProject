using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameWinTimeScript : MonoBehaviour
{
    public Text timerText;

    // Start is called before the first frame update
    void Start()
    {
        int minutes = (int)PlayerPrefs.GetFloat("GameTimerMinutes");

        timerText.text = "Time: " + minutes.ToString() + ":" + PlayerPrefs.GetFloat("GameTimerSeconds").ToString("f2");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
