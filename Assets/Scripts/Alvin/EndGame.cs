using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EndGame : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
      
    }

    public void WinGame() // Funktion som heter Wingame.
    {
        SceneManager.LoadScene(3); // Laddar Scene 3 i builden.
    }
}
//Alvin