using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    private Rigidbody2D r2d;
    private float timer;
    [SerializeField]
    private GameObject bottlePrefab;
    [SerializeField, Range(1,10)]
    public int throwDelay = 5;
    [SerializeField]
    private GameObject arm;
    [SerializeField]
    private GameObject Aim;
    private GameObject player;
    public bool stageOne = true;
    public int playerInBox = 0;
    public int andrewInBox = 0;
    private float jumpAttackTimer = 0;
    private CameraShake cameraShake;
    [SerializeField]
    private GameObject bossCamera;
    [SerializeField]
    private Transform groundCheck;
    [SerializeField]
    private LayerMask groundLayer;

    public bool AndrewGround1;
    public bool AndrewGround2;
    public bool AndrewGround3;

    public bool bossFightStart = false;

    public int currentHealth = 20;
    // Start is called before the first frame update
    void Start()
    {
        r2d = gameObject.GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player");
        cameraShake = bossCamera.GetComponent<CameraShake>();


    }
    // Update is called once per frame
    float timer4;
    void Update()
    {
        print(currentHealth);
        jumpAttackTimer += Time.deltaTime;
        if (stageOne == true && bossFightStart == true)
        {
            arm.transform.LookAt(player.transform.position);
            timer += Time.deltaTime;
            if (timer >= (1 * throwDelay))
            {
                timer = 0;
                Instantiate(bottlePrefab, arm.transform.position, Quaternion.identity);
                Debug.Log("Bottle!");
            }
        }

        else if (stageOne == false)
        {
            if (jumpAttackTimer >= 7)
            {
                if (playerInBox == 1)
                {
                    if (andrewInBox == 1)
                    {
                        //Dune
                        r2d.velocity = new Vector2(r2d.velocity.x, 25);
                    }
                    else if (andrewInBox == 2)
                    {
                        //Dune
                        r2d.velocity = new Vector2(-6, 25);
                    }
                    else if (andrewInBox == 3)
                    {
                        //Dune
                        r2d.velocity = new Vector2(-13, 25);
                    }
                }
                else if(playerInBox == 2)
                {
                    if (andrewInBox == 1)
                    {
                        //Dune
                        r2d.velocity = new Vector2(7, 25);
                    }
                    else if (andrewInBox == 2)
                    {
                        //Dune
                        r2d.velocity = new Vector2(r2d.velocity.x, 25);
                    }
                    else if (andrewInBox == 3)
                    {
                        //Dune
                        r2d.velocity = new Vector2(-7, 25);
                    }
                }
                else if(playerInBox == 3)
                {
                    if (andrewInBox == 1)
                    {
                        //Dune
                        r2d.velocity = new Vector2(13, 25);
                    }
                    else if (andrewInBox == 2)
                    {
                        //Dune
                        r2d.velocity = new Vector2(6, 25);
                    }
                    else if (andrewInBox == 3)
                    {
                        //Dune
                        r2d.velocity = new Vector2(r2d.velocity.x, 25);
                    }
                }
                jumpAttackTimer = 0;
            }
        }
        else
        {
            Debug.Log("Uuuuuuuuhh, something wrong here!!!");
        }
        if (currentHealth <= 10)
        {
            stageOne = false;
        }
        else if (currentHealth <= 0)
        {
            Debug.Log("Andrews Dead");
        }
        else
        {
            stageOne = true;
        }
    }
    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.5f, groundLayer);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (stageOne == false)
        {
            if (collision.gameObject.name == "GroundCheck (1)" && jumpAttackTimer >= 2)
            {
                cameraShake.start = true;
                r2d.velocity = new Vector2(0, 0);
                transform.position = new Vector3(390, transform.position.y, transform.position.z);
                AndrewGround1 = false;
            }
            else if (collision.gameObject.name == "GroundCheck (2)" && jumpAttackTimer >= 2)
            {
                cameraShake.start = true;
                r2d.velocity = new Vector2(0, 0);
                transform.position = new Vector3(406, transform.position.y, transform.position.z);
                AndrewGround2 = false;
            }
            else if (collision.gameObject.name == "GroundCheck (3)" && jumpAttackTimer >= 2)
            {
                cameraShake.start = true;
                r2d.velocity = new Vector2(0, 0);
                transform.position = new Vector3(423, transform.position.y, transform.position.z);
                AndrewGround3 = false;
            }

        }
        if (collision.gameObject.tag == "Boomerang")
        {
            TakeDamage(1);
        }
    }
    public void TakeDamage(int damage)
    {
        currentHealth = currentHealth - damage;
        if (currentHealth <= 10)
        {
            stageOne = false;
        }
        else if (currentHealth <= 0)
        {
            Debug.Log("Andrews Dead");
        }
        else
        {
            stageOne = true;
        }
    }
}
