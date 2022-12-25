using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public GameObject optionsMenu, mainMenu;
    public void PlayGame()
    {
        SceneManager.LoadScene("Levels/Game");
    }//Oyunun olduğu sahneyi yükler ve oyunu başlatmış olur.

    public void OptionsMenu()
    {
        optionsMenu.SetActive(true);
        mainMenu.SetActive(false);
    }//Ayarlar menüsünü ekrana getirip ana menüyü gizler.

    public void GoMainMenu()
    {
        SceneManager.LoadScene("Levels/MainMenu");
        Time.timeScale = 1f;
    }//Oynarken öldükten sonra ana menüye geri döner ve oyun hızını normale çevirir.

    public void PlayAgain()
    {
        SceneManager.LoadScene("Levels/Game");
        Time.timeScale = 1f;
    }//Oyunu tekrar başlatır ve oyun hızını normale çevirir.
    public void BackMainMenu()
    {
        mainMenu.SetActive(true);
        optionsMenu.SetActive(false);
    }//Ayarlar menüsünden ana menüye geri döner ve ayarlar menüsünü gizler.
    public void QuitButton()
    {
        Application.Quit();
    }//Oyunu kapatır.
}
