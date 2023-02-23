using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour
{
    public int maxHealth = 3;// best�mmer max hp p� enemy
    public int currentHealth;// best�mmer hur mycket hp snemin ska ha
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;// n�r den spawnar s� har den max health 
        anim = GetComponent<Animator>();
    }

   public void TakeDamage(int amount)
    {
        currentHealth -= amount;// g�r s� att man tar damage 
        anim.SetTrigger("hurt");// animation n�r den tar damage 
        if (currentHealth <= 0)// om health �r minre �n 0 s� f�rst�r enemy och spela animationen die
        {
            Destroy(gameObject);
            Invoke("die", 0.7f);// chillar med att g� ut ur scenen med 0.7 sekunder 
            anim.SetTrigger("die");
        }

    }
}
