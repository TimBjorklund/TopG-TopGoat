using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Healthbar : MonoBehaviour
{
    public Slider slider;
    public Gradient gradient;
    public Image fill;
   
    public float health;
    public float currentHealth;
    public float maxHealth = 4f;
    public float damage = 10f;
    public Healthbar healthbar;

    void Start()
    {
        currentHealth = maxHealth;     //när spelet börjar sätts hp till fullt
        SetMaxHealth(maxHealth);
    }



    public void SetMaxHealth(float health1) //funktion som startar healthbaren
    {
        Debug.Log("SetMaxHealth");
        slider.maxValue = health1;  //max value health i början
        slider.value = health1;  //healthbaren anpassas efter hp

        fill.color = gradient.Evaluate(1f); //fyll helt (1)
    }

    public void SetHealth(float health2)  //funktion som gör att healthbaren anpassas efter hp 
    {
        slider.value = health2; // -||-

        fill.color = gradient.Evaluate(slider.normalizedValue); //fyll i 
        Debug.Log("anpassning till bar");
    }

    public void TakeDamage(float damage) //funktion som heter takedamage
    {
        currentHealth -= damage;
        slider.value -= damage;
        SetHealth(currentHealth);

    }
    void die() //funktion som är att dö
    {
        SceneManager.LoadScene(2); //ladda game over scene
    }
    void Update()
    {

        if (health <= 0) //om hp är mindre än ELLER LIKA MED 0
        {
             Invoke("die", 0.7f);
        }

    }
}

//Alvin