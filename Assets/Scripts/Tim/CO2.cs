using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CO2 : PowerUp
{
    public int Score;


    public override void OnCollisionEnter2D(Collision2D collision)
    {
        base.OnCollisionEnter2D(collision);
        Score++;
    }
}
