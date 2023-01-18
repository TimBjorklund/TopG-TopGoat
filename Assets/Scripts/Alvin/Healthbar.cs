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
    public float maxHealth = 100f;
    public Healthbar healthbar;
    public float damage = 10f;

    void Start()
    {
        currentHealth = maxHealth;     //när spelet börjar sätts hp till fullt
        healthbar.SetMaxHealth(maxHealth);
    }



    public void SetMaxHealth(float health) //funktion som startar healthbaren
    {
        slider.maxValue = health;  //max value ? health i början
        slider.value = health;  //healthbaren anpassas efter hp

        fill.color = gradient.Evaluate(1f); //fyll helt (1)
    }

    public void SetHealth(float health)  //funktion som gör att healthbaren anpassas efter hp 
    {
        slider.value = health; // -||-

        fill.color = gradient.Evaluate(slider.normalizedValue); //fyll i 
    }

    public void TakeDamage(float damage) //funktion som heter takedamage
    {
        currentHealth -= damage;
        healthbar.SetHealth(currentHealth);
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