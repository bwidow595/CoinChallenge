using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControl : MonoBehaviour
{
    //---------- Main Menu ----------
    public void ReturnMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
    public void QuitGameMenu()
    {
        Application.Quit();
    }


    //---------- Game Over Panel ----------
    public void ReturnMenuGO()
    {
        SceneManager.LoadScene("Menu");
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.LogWarning("Quit game");
    }

}
