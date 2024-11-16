using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuManager : MonoBehaviour
{
    public GameObject settingsPanel;
    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
    }
    public void ExitGame()
    {
        Application.Quit();
    }
    public void Settings()
    {
        settingsPanel.SetActive(true);
    }
    public void Exit()
    {
        settingsPanel.SetActive(false);
    }
}
