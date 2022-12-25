using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseResume : MonoBehaviour
{
    public GameObject pause, pauseBackground;
    public void ClickResume()
    {
        pauseBackground.SetActive(false);
        Time.timeScale = 1f;
        pause.SetActive(true);
    }//Oyunu devam ettirir.

    public void ClickPause()
    {
        pauseBackground.SetActive(true);
        Time.timeScale = 0f;
        pause.SetActive(false);

    }//Oyunu duraklatır.
}
