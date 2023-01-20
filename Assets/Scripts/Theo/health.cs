using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour
{
    public int maxHealth = 3;
    public int currentHealth;
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        anim = GetComponent<Animator>();
    }

   public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        anim.SetTrigger("hurt");
        if (currentHealth <= 0)
        {
            Destroy(gameObject);
            Invoke("die", 0.7f);
            anim.SetTrigger("die");
        }

    }
}
