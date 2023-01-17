using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponBoomerang : MonoBehaviour
{
    private Rigidbody2D r2d;
    public int score;
    public bool hitWall;
    public bool hitEnemy;
    public bool maxRange;
    private float timer = 0;
    public float timer2 = 0;
    Player player;
    [SerializeField]
    private Vector3 towardsPosition;
    private GameObject towardsPositionStart;
    [SerializeField]
    float boomerangSpeed = 1;
    [SerializeField]
    GameObject Spinning;

    // Start is called before the first frame update
    void Start()
    {
        r2d = gameObject.GetComponent<Rigidbody2D>();
        player = FindObjectOfType<Player>();
        towardsPositionStart = GameObject.FindGameObjectWithTag("TowardsPosition");
        towardsPosition = towardsPositionStart.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Spinning.transform.eulerAngles += new Vector3(0,0,200) * Time.deltaTime;
        timer += Time.deltaTime;
        timer2 += Time.deltaTime;
        if (hitEnemy == true || timer2 >= 1 || hitWall == true)
        {
            r2d.AddForce(player.transform.position*boomerangSpeed/2 - transform.position*boomerangSpeed/2);
        }
        else if (timer2 >= 10)
        {
            transform.position = player.transform.position;
        }
        else
        {
            r2d.AddForce(towardsPosition*boomerangSpeed - transform.position*boomerangSpeed);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            score++;
        } 
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && timer >= 1)
        {
            Destroy(gameObject);
            player.haveWeapon = true;
            Debug.Log("HIIIIIT!");
        }
    }
}