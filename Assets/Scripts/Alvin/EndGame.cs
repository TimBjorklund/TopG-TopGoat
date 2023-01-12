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

    public void WinGame()
    {
        SceneManager.LoadScene(3);
    }
}