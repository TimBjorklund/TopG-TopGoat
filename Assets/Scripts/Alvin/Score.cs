using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour
{

    public static int scored;


    public Text scoreText;


    void Start()
    {
        scoreText = GetComponent<Text>();
    }


    void Update()
    {
        scoreText.text = scored.ToString();
    }

}
//Alvin