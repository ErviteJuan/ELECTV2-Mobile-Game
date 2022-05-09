using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScreen : MonoBehaviour
{
    public GameObject pauseUI, MainUI, HowToPlayUI, pauseDefault;
    private void Start()
    {
        Time.timeScale = 1;
    }
    public void PauseButton()
    {
        Time.timeScale = 0;
        pauseUI.SetActive(true);
        MainUI.SetActive(false);
    }

    public void ResumeButton()
    {
        Time.timeScale = 1;
        pauseUI.SetActive(false);
        MainUI.SetActive(true);
    }
    public void HowtoPlayButton()
    {
        pauseDefault.SetActive(false);
        HowToPlayUI.SetActive(true);
    }
    public void BackButton()
    {
        pauseDefault.SetActive(true);
        HowToPlayUI.SetActive(false);
    }
    public void QuitButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        Time.timeScale = 1;
    }
}
