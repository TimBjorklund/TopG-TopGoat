using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Jag hann inte fixa score ui eller liknade har bara koden men det kommer impleteras vi jobbar med detta senare.
public class Score : MonoBehaviour
{

    public static int scored;


    public Text scoreText;


    void Start()
    {
        scoreText = GetComponent<Text>();// Denna betyder att scoretexten är samma sak som när vi hitta compenenten text där det står poängen.
    }


    void Update()
    {
        scoreText.text = scored.ToString();
    }

}
//Alvin