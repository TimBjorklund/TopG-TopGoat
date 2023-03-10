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
        if (collision.gameObject.tag == "Player")
        {
            if (gameObject.name == "Box (1)")
            {
                boss.playerInBox = 1;
            }
            else if (gameObject.name == "Box (2)")
            {
                boss.playerInBox = 2;
            }
            else if (gameObject.name == "Box (3)")
            {
                boss.playerInBox = 3;
            }
            else
            {
                Debug.Log("Somthing wrong in BoxChacks");
            }
        }
        if (collision.gameObject.tag == "Andrew")
        {
            if (gameObject.name == "Box (1)")
            {
                boss.andrewInBox = 1;
            }
            else if (gameObject.name == "Box (2)")
            {
                boss.andrewInBox = 2;
            }
            else if (gameObject.name == "Box (3)")
            {
                boss.andrewInBox = 3;
            }
            if (gameObject.name == "Ground (1)")
            {
                boss.AndrewGround1 = true;
            }
            else if (gameObject.name == "Ground (2)")
            {
                boss.AndrewGround2 = true;
            }
            else if (gameObject.name == "Ground (3)")
            {
                boss.AndrewGround3 = true;
            }
        }
    }
}
