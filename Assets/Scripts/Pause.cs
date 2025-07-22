using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{

    [SerializeField] GameObject pauseScreen;
    // Start is called before the first frame update


   public void OnPause()
    {
        pauseScreen.SetActive(true);
        Time.timeScale = 0f;
    }

    public void backToGame()
    {
        pauseScreen.SetActive(false);
        Time.timeScale = 1f;
    }

    public void backToMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Close()
    {
        Application.Quit();
    }
}
