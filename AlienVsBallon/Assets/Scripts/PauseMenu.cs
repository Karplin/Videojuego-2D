using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;
  
    public void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }


    public void Restart()
    {
        pauseMenu.SetActive(false);
        SceneManager.LoadScene("Gameplay");
        Scorescript.scoreValue = 5;
        Time.timeScale = 1f;
    }

    public void Home(int SceneID)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneID);
        Scorescript.scoreValue = 5;
    }


}
