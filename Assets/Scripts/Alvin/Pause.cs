using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Pause : MonoBehaviour
{


    public void Start()
    {
        Resume();
    }


    public static bool GameIsPaused = false; // H�r g�r jag en bool som har v�rdet False.

    public GameObject PausedUI; // H�r g�r jag ett gameobject d�r jag l�gger in canvasen i (d�r scriptsen finns)
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) // Om escape blir tryckt s� kopplas paused med resume some en knapp och else paused
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
    public void Resume () // Om boolen aktiveras s� e den false o d� �r tiden 1. samt spelet e pausat
    {
        PausedUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;

    }
    void Paused() // Om paused s� �r den true o tiden e 0.
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
        Debug.Log("Greta left the game."); //skriv i logs att spelaren l�mnade spelet  
    }

}
