using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public GameObject MainUI, HowToPlayUI;

    public void Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void HowtoPlay()
    {
        MainUI.SetActive(false);
        HowToPlayUI.SetActive(true);
    }
    public void Return()
    {
        MainUI.SetActive(true);
        HowToPlayUI.SetActive(false);
    }
}
