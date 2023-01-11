using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame() //funktion som heter playgame
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //ladda in nästa scene från build settings
    }
    public void QuitGame() //funktion som heter quitgame
    {
        Application.Quit(); //avsluta applikationen
        Debug.Log("Greta left the game"); //skriv i logs att spelaren lämnade
    }
}