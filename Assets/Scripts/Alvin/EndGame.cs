using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EndGame : MonoBehaviour
{
    //Här gör jag en collison så när gubben som har taggen player coliderar med ett gameobject som har taggen player så destroyas greta och loadar scene 2 i builden.
    public void OnCollisionEnter2D(Collision2D collision) 
    {
        if (collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(2);
            Destroy(gameObject);
        }
        //^^
        //Här gör jag en collison så när gubben som har taggen Win coliderar med ett gameobject som har taggen player så kommer det upp en  och loadar scene 2 i builden.
        else if (collision.gameObject.tag == "Win")
        {
            SceneManager.LoadScene(3);
            Destroy(gameObject);
        }
    }
    //^^



    public void WinGame() // Funktion som heter Wingame.
    {
        SceneManager.LoadScene(3); // Laddar Scene 3 i builden.
    }
    public void Die() //funktion som är att dö
    {
       
        SceneManager.LoadScene(2); //ladda game over scene
    }
}
//Alvin