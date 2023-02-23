using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour
{
    public int maxHealth = 3;// bestämmer max hp på enemy
    public int currentHealth;// bestämmer hur mycket hp snemin ska ha
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;// när den spawnar så har den max health 
        anim = GetComponent<Animator>();
    }

   public void TakeDamage(int amount)
    {
        currentHealth -= amount;// gör så att man tar damage 
        anim.SetTrigger("hurt");// animation när den tar damage 
        if (currentHealth <= 0)// om health är minre än 0 så förstör enemy och spela animationen die
        {
            Destroy(gameObject);
            Invoke("die", 0.7f);// chillar med att gå ut ur scenen med 0.7 sekunder 
            anim.SetTrigger("die");
        }

    }
}
