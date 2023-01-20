using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Healthbar : MonoBehaviour
{
    public Animator animator;
    public Slider slider;
    public Gradient gradient;
    public Image fill;
    public float health;
    public float maxHealth = 4f;
    public float damage = 1f;
    public Healthbar healthbar;

    void Start()
    {
        health = maxHealth;     //när spelet börjar sätts hp till fullt
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
        slider.value = health; 

        fill.color = gradient.Evaluate(slider.normalizedValue); //fyll i 
        Debug.Log("anpassning till bar");
    }

    public void TakeDamage(float damage) //i denna funktion gör vi så att health minskas och att slidervalue minskas och då sätter vi sethelth till nuvarande hpn.
    {
        animator.SetTrigger("Hurt");
        health -= damage;
        slider.value -= damage;
        SetHealth(health);
        

    }

    
    void die() //funktion som är att dö
    {
        SceneManager.LoadScene(2); //ladda game over scene
    }
    void Update()
    {
        if (health <= 0) //om hp är mindre än ELLER LIKA MED 0
        {
             Invoke("die", 2f);
             animator.SetTrigger("Die");
        }
        

    }
}

//Alvin