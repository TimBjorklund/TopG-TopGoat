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
    [SerializeField]
    private GameObject player;
    public bool stageOne = true;
    public int playerInBox = 0;
    public int andrewInBox = 0;
    private float jumpAttackTimer = 0;
    private GameObject box1;
    private GameObject box2;
    private GameObject box3;
    [SerializeField]
    private Transform groundCheck;
    [SerializeField]
    private LayerMask groundLayer;

    public bool AndrewGround1;
    public bool AndrewGround2;
    public bool AndrewGround3;
    // Start is called before the first frame update
    void Start()
    {
        r2d = gameObject.GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player");
        box1 = GameObject.FindGameObjectWithTag("Box1");
        box2 = GameObject.FindGameObjectWithTag("Box2");
        box3 = GameObject.FindGameObjectWithTag("Box3");
    }
    // Update is called once per frame
    float timer4;
    void Update()
    {
        jumpAttackTimer += Time.deltaTime;
        if (stageOne == true)
        {
            arm.transform.LookAt(player.transform.position);
            timer += Time.deltaTime;
            if (timer >= (1 * throwDelay))
            {
                timer = 0;
                Instantiate(bottlePrefab, arm.transform.position, Quaternion.identity);
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
    }
    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.5f, groundLayer);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (stageOne == false)
        {
            if (AndrewGround1 == true)
            {
                transform.position = new Vector3(-17, transform.position.y, transform.position.z);
                AndrewGround1 = false;
            }
            else if (AndrewGround2 == true)
            {
                transform.position = new Vector3(0, transform.position.y, transform.position.z);
                AndrewGround2 = false;
            }
            else if (AndrewGround3 == true)
            {
                transform.position = new Vector3(17, transform.position.y, transform.position.z);
                AndrewGround3 = false;
            }

        }
    }
}
