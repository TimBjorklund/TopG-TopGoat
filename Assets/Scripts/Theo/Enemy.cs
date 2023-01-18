using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [Header("Jag l�mnar min dator ol�st i en korridor p� skolan")]
    [SerializeField] private float attackcooldown;
    [SerializeField] private float range;
    [SerializeField] private float colliderDistance;
    [SerializeField] private int damage;
    [SerializeField] private BoxCollider2D boxCoxColider;
    private float cooldownTimer = 0;
    [SerializeField] private LayerMask PlayerLayer;

    private Animator anim;
    private health playerhealth;

    private EnemyPatrol enemyPatrol;

    Healthbar health;
    private void Awake()
    {
        anim = GetComponent<Animator>();
        enemyPatrol = GetComponentInParent<EnemyPatrol>();
        health = FindObjectOfType<Healthbar>();
    }

    private void Update()
    {
         
        cooldownTimer += Time.deltaTime;

        if (PlayerInSight())
        {
            if (cooldownTimer >= attackcooldown)
            {
                print("attack");
                cooldownTimer = 0;
                anim.SetTrigger("melee");
                health.health -= 1;
            }
        }

        if (enemyPatrol != null)
            enemyPatrol.enabled = !PlayerInSight(); //G�r s� att enemy patrullerar n�r den inte ser player - Adam
    }
    private bool PlayerInSight()
    {
       Collider2D hit = Physics2D.OverlapBox(boxCoxColider.bounds.center + transform.right * range * transform.localScale.x * colliderDistance,
        new Vector3(boxCoxColider.bounds.size.x * range, boxCoxColider.bounds.size.y, boxCoxColider.bounds.size.z), 0, PlayerLayer);

        if (hit != null)
        {
            /* playerhealth = hit.transform.GetComponent<health>();
             playerhealth.currentHealth -= 1;*/
            
            print("damage");
            return true;
        }else
        {
            return false;
        }

    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(boxCoxColider.bounds.center + transform.right * range * transform.localScale.x * colliderDistance,
        new Vector3(boxCoxColider.bounds.size.x * range, boxCoxColider.bounds.size.y, boxCoxColider.bounds.size.z));
    }
    private void DamagePlayer()
    {
       
        
    }
}

