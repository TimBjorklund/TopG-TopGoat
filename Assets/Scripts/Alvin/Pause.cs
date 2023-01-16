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


    public static bool GameIsPaused = false; // Här gör jag en bool som har värdet False.

    public GameObject PausedUI; // Här gör jag ett gameobject där jag lägger in canvasen i (där scriptsen finns)
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) // Om escape blir tryckt så kopplas paused med resume some en knapp och else paused
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
    public void Resume () // Om boolen aktiveras så e den false o då är tiden 1. samt spelet e pausat
    {
        PausedUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;

    }
    void Paused() // Om paused så är den true o tiden e 0.
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
