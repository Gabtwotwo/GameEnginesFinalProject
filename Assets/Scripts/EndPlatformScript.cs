using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndPlatformScript : MonoBehaviour
{
    private float startTime;
    private float minutes;
    private float seconds;

    void Start()
    {
        startTime = Time.time;

        
    }

    void Update()
    {
        float t = Time.time - startTime;

        minutes = t / 60;
        seconds = t % 60;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            PlayerPrefs.SetFloat("GameTimerMinutes", minutes);
            PlayerPrefs.SetFloat("GameTimerSeconds", seconds);
            SceneManager.LoadScene("GameWin");
        }
    }
}
