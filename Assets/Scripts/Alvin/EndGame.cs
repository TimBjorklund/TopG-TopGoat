using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EndGame : MonoBehaviour
{
    public GameObject[] enemies;




    //H�r g�r jag en collison s� n�r gubben som har taggen player coliderar med ett gameobject som har taggen player s� destroyas greta och loadar scene 2 i builden.
    public void OnCollisionEnter2D(Collision2D collision) 
    {
        if (collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(2);
            Destroy(gameObject);
        }
        //^^
      
        
        // (ON�DIG d� vi har annat vinn system) H�r g�r jag en collison s� n�r gubben som har taggen Win coliderar med ett gameobject som har taggen player s� kommer det upp en win scene.
        else if (collision.gameObject.tag == "Win")
        {
            SceneManager.LoadScene(3);
            Destroy(gameObject);
        }
    }
         //^^



    public void WinGame() // Funktion som heter Wingame.
    {
        enemies = GameObject.FindGameObjectsWithTag("Enemy"); // letar efter saker med tagg Enemy. 
        if (enemies.Length == 0)
        {
            SceneManager.LoadScene("GameWon"); // Laddar in i vinn scenen
        }

    }
    public void Die() //funktion som �r att d�
    {
       
        SceneManager.LoadScene(2); //ladda game over scene
    }
}
//Alvin