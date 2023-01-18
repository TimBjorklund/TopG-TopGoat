using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float attackcooldown;
    [SerializeField] private float range;
    [SerializeField] private float colliderDistance;
    [SerializeField] private int damage;
    [SerializeField] private BoxCollider2D boxCoxColider;
    private float cooldownTimer = Mathf.Infinity;
    [SerializeField] private LayerMask PlayerLayer;

    private Animator anim;
    private health playerhealth;

    private EnemyPatrol enemyPatrol;
    private void Awake()
    {
        anim = GetComponent<Animator>();
        enemyPatrol = GetComponentInParent<EnemyPatrol>();
    }

    private void Update()
    {
        cooldownTimer += Time.deltaTime;

        if (PlayerInSight())
        {
            if (cooldownTimer >= attackcooldown)
            {
                cooldownTimer = 0;
                anim.SetTrigger("attack!");
                
            }
        }

        if (enemyPatrol != null)
            enemyPatrol.enabled = !PlayerInSight(); //G�r s� att enemy patrullerar n�r den inte ser player - Adam
    }
    private bool PlayerInSight()
    {
        RaycastHit2D hit = Physics2D.BoxCast(boxCoxColider.bounds.center + transform.right * range * transform.localScale.x * colliderDistance, 
        new Vector3(boxCoxColider.bounds.size.x * range, boxCoxColider.bounds.size.y, boxCoxColider.bounds.size.z), 0, Vector2.left, 0, PlayerLayer);

        if (hit.collider != null)
        {
            playerhealth = hit.transform.GetComponent<health>();
            playerhealth.currentHealth -= 1;
            print("damage");
        }

        return hit.collider != null;
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(boxCoxColider.bounds.center + transform.right * range * transform.localScale.x * colliderDistance,
        new Vector3(boxCoxColider.bounds.size.x * range, boxCoxColider.bounds.size.y, boxCoxColider.bounds.size.z));
    }
    private void DamagePlayer()
    {
        print("attack!!!");
        if (PlayerInSight())
        {
          
        }
    }
}

