using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScreen : MonoBehaviour
{
    public GameObject pauseUI, MainUI;
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
    public void QuitButton()
    {
        SceneManager.LoadScene
    }
}
