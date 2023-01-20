using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxChecks : MonoBehaviour
{
    private Boss boss;

    private void Start()
    {
        boss = FindObjectOfType<Boss>();
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("Collision");
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Player in");
            print(gameObject.name);
            if (gameObject.name == "Box (1)")
            {
                boss.playerInBox = 1;
                Debug.Log("Player in box 1");
            }
            else if (gameObject.name == "Box (2)")
            {
                boss.playerInBox = 2;
                Debug.Log("Player in box 2");
            }
            else if (gameObject.name == "Box (3)")
            {
                boss.playerInBox = 3;
                Debug.Log("Player in box 3");
            }
            else
            {
                Debug.Log("Somthing wrong in BoxChacks");
            }
        }
        if (collision.gameObject.tag == "Andrew")
        {
            Debug.Log("Andrew in");
            if (gameObject.name == "Box (1)")
            {
                boss.andrewInBox = 1;
                Debug.Log("Andrew in box 1");
            }
            else if (gameObject.name == "Box (2)")
            {
                boss.andrewInBox = 2;
                Debug.Log("Andrew in box 2");
            }
            else if (gameObject.name == "Box (3)")
            {
                boss.andrewInBox = 3;
                Debug.Log("Andrew in box 3");
            }
            else
            {
                Debug.Log("Somthing wrong in BoxChacks");
            }
        }
    }
}
