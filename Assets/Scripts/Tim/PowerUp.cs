using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public KeyCode Test;
    public virtual void Update()
    {
        if (Input.GetKeyDown(Test))
        {
            Debug.Log("Hello!");
        }

    }
}
