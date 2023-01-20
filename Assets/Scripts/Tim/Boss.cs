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
        timer4 += Time.deltaTime;
        if (timer4 >=7)
        {
            r2d.velocity = new Vector2( 4, 25);
            timer4 = 0;
        }
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
            if (jumpAttackTimer >= 5)
            {
                if (playerInBox == 1)
                {
                    if (andrewInBox == 1)
                    {
                        r2d.velocity = new Vector2(r2d.velocity.x, 25);
                    }
                    else if (andrewInBox == 2)
                    {
                        r2d.velocity = new Vector2(4, 25);
                    }
                    else if (andrewInBox == 3)
                    {
                        r2d.velocity = new Vector2(r2d.velocity.x, 25);
                        for (int i = 0; i < 100; i++)
                        {
                            transform.position += (box1.transform.position -= box3.transform.position) / 100;
                        }
                    }
                }
                else if(playerInBox == 2)
                {
                    if (andrewInBox == 1)
                    {
                        r2d.velocity = new Vector2(r2d.velocity.x, 25);
                        for (int i = 0; i < 100; i++)
                        {
                            transform.position += (box2.transform.position -= box1.transform.position) / 100;
                        }
                    }
                    else if (andrewInBox == 2)
                    {
                        r2d.velocity = new Vector2(r2d.velocity.x, 25);
                    }
                    else if (andrewInBox == 3)
                    {
                        r2d.velocity = new Vector2(r2d.velocity.x, 25);
                        for (int i = 0; i < 100; i++)
                        {
                            transform.position += (box2.transform.position -= box3.transform.position) / 100;
                        }
                    }
                }
                else if(playerInBox == 3)
                {
                    if (andrewInBox == 1)
                    {
                        r2d.velocity = new Vector2(r2d.velocity.x, 25);
                        for (int i = 0; i < 100; i++)
                        {
                            transform.position += (box3.transform.position -= box1.transform.position) / 100;
                        }
                    }
                    else if (andrewInBox == 2)
                    {
                        r2d.velocity = new Vector2(r2d.velocity.x, 25);
                        for (int i = 0; i < 100; i++)
                        {
                            transform.position += (box3.transform.position -= box2.transform.position) / 100;
                        }
                    }
                    else if (andrewInBox == 3)
                    {
                        r2d.velocity = new Vector2(r2d.velocity.x, 25);

                    }
                }
            }
        }
        else
        {
            Debug.Log("Uuuuuuuuhh, something wrong here!!!");
        }
    }
}
