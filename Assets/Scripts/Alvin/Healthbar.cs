using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class HealthBar : MonoBehaviour
{
    public Slider slider;
    public Gradient gradient;
    public Image fill;
   
    public float health;
    public float currentHealth;
    public float maxHealth = 100f;
    public HealthBar healthbar;
    public float damage = 0.08f;

    void Start()
    {
        currentHealth = maxHealth;     //n�r spelet b�rjar s�tts hp till fullt
        healthbar.SetMaxHealth(maxHealth);
    }



    public void SetMaxHealth(float health) //funktion som startar healthbaren
    {
        slider.maxValue = health;  //max value ? health i b�rjan
        slider.value = health;  //healthbaren anpassas efter hp

        fill.color = gradient.Evaluate(1f); //fyll helt (1)
    }

    public void SetHealth(float health)  //funktion som g�r att healthbaren anpassas efter hp 
    {
        slider.value = health; // -||-

        fill.color = gradient.Evaluate(slider.normalizedValue); //fyll i 
    }

    void TakeDamage(float damage) //funktion som heter takedamage
    {
        currentHealth -= damage;
        healthbar.SetHealth(currentHealth);
    }
    void die() //funktion som �r att d�
    {
        SceneManager.LoadScene(2); //ladda game over scene
    }
    void Update()
    {

        if (currentHealth <= 0) //om hp �r mindre �n ELLER LIKA MED 0
        {
            die(); //k�r funktionen die
        }

    }
}

//Alvin