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

    public void onControlsButtonBehaviour()
    {
        SceneManager.LoadScene("Controls");
    }

    public void onCreditsButtonBehaviour()
    {
        SceneManager.LoadScene("Credits");
    }

    public void onEndButtonBehaviour()
    {
        Application.Quit();
    }

    public void onBackButtonBehaviour()
    {
        SceneManager.LoadScene("MainMenu");
    }


}
