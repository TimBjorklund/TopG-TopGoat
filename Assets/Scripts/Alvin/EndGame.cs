using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EndGame : MonoBehaviour
{
    //H�r g�r jag en collison s� n�r gubben som har taggen player coliderar med ett gameobject som har taggen player s� destroyas greta och loadar scene 2 i builden.
    public void OnCollisionEnter2D(Collision2D collision) 
    {
        if (collision.gameObject.tag == "Player")
        {
            
            SceneManager.LoadScene(2);
            Destroy(gameObject);
        }
    }
    //^^
    public void WinGame() // Funktion som heter Wingame.
    {
        SceneManager.LoadScene(3); // Laddar Scene 3 i builden.
    }
    public void Die() //funktion som �r att d�
    {
       
        SceneManager.LoadScene(2); //ladda game over scene
    }
}
//Alvin