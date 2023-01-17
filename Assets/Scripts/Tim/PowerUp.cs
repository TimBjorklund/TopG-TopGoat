using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public virtual void Start()
    {
        
    }
    public KeyCode Test;
    public virtual void Update()
    {

        if (Input.GetKeyDown(Test))
        {
            Debug.Log("Hello!");
        }

    }
    public virtual void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }

    }
}
