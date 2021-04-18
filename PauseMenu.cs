using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pause_menu;
    bool paused = false;

    public void Resume()
    {
        Time.timeScale = 1;
        pause_menu.SetActive(false);
        paused = false;
    }
    public void QuitToDesktop() { Application.Quit(); } 
    public void RestartLevel()
    {
        Resume();
        SceneManager.LoadScene("FugasWorld");
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (paused == true)
                Resume();
            else
            {
                Time.timeScale = 0;
                pause_menu.SetActive(true);
                paused = true;
            }
        }
    }
}
