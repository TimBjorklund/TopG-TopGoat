using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public int GretaScore; 

    public Text scoreText; 
    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<Text>(); //h�r g�r jag s� den h�mtar competenten text.
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "GretaScore"; 
    }
     
}
//Alvin