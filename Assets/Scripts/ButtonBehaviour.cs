using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonBehaviour : MonoBehaviour
{
 
    public void onStartButtonBehaviour()
    {
        SceneManager.LoadScene("Game");
    }

    public void onEndButtonBehaviour()
    {
        Application.Quit();
    }


}
