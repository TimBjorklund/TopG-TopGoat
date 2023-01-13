using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Pause : MonoBehaviour
{

    public static bool GameIsPaused = false;

    public GameObject PausedUI;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
 
            } else
            {
                Paused();
            }
        }
    }
    public void Resume ()
    {
        PausedUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;

    }
    void Paused()
    {
        PausedUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
    public void BackToMain() //funktion BackToMain
    {
        SceneManager.LoadScene(0); //ladda scen 0 (Main Menu)
    }

    public void QuitGame() //funktion quitgame
    {
        Application.Quit(); //avsluta applikatione
        Debug.Log("Greta left the game."); //skriv i logs att spelaren lämnade spelet  
    }

}
