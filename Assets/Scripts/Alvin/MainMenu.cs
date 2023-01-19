using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame() //funktion som heter playgame
    {
        SceneManager.LoadScene("MainScene", LoadSceneMode.Single); //ladda in n�sta scene fr�n build settings
    }
    public void QuitGame() //funktion som heter quitgame
    {
        Application.Quit(); //avslutar applikationen
        Debug.Log("Greta left the game"); 

    }
}

//Alvin