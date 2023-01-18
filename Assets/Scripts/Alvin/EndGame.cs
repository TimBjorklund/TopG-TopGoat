using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EndGame : MonoBehaviour
{
    
    void OnTriggerEnter(Collider other)
    {
        WinGame();
    }
   
    public void WinGame() // Funktion som heter Wingame.
    {
        SceneManager.LoadScene(3); // Laddar Scene 3 i builden.
    }
    public void Die() //funktion som är att dö
    {
       
        SceneManager.LoadScene(4); //ladda game over scene
    }
}
//Alvin