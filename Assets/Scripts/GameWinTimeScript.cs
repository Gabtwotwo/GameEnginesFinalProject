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

            if (PlayerPrefs.GetFloat("GameTimerSeconds") > 40)
            {
                timerText.text = "Time: " + minutes.ToString() + ":" + PlayerPrefs.GetFloat("GameTimerSeconds").ToString("f2") + " You've earned a bronze medal. There are better scores out there!";
            }
            else if (PlayerPrefs.GetFloat("GameTimerSeconds") > 30)
            {
                timerText.text = "Time: " + minutes.ToString() + ":" + PlayerPrefs.GetFloat("GameTimerSeconds").ToString("f2") + " You've earned a silver medal. Go for the gold!";
            }
            else if (PlayerPrefs.GetFloat("GameTimerSeconds") > 20)
            {
                timerText.text = "Time: " + minutes.ToString() + ":" + PlayerPrefs.GetFloat("GameTimerSeconds").ToString("f2") + " You've earned a gold medal. You've acheved the tippy top!";
            }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
