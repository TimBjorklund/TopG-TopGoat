using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public void ResetGame() //funktion resetgame
    {
        SceneManager.LoadScene(1); //ladda scen 1 (direkt in i spelet)
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

// Alvin