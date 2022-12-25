using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Bu script oyuna eklenmemiştir. İşlevsizdir.
//Bu script oyuna eklenmemiştir. İşlevsizdir.
//Bu script oyuna eklenmemiştir. İşlevsizdir.

public class OptionsMenu : MonoBehaviour
{
    public void BackButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }
}
