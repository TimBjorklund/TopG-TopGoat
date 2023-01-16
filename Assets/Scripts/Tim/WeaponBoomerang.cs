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
    public float timer = 0;
    Player player;
    [SerializeField]
    Vector3 towardsPosition;
    [SerializeField]
    GameObject towardsPositionStart;
    [SerializeField]
    float boomerangSpeed = 1;

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
        timer += Time.deltaTime;
        if (hitEnemy == true || towardsPosition == transform.position || hitWall == true)
        {
            r2d.AddForce(player.transform.position*boomerangSpeed - transform.position);
            Debug.Log("MaxRangeReached!");
        }
        else
        {
            r2d.AddForce(towardsPosition*boomerangSpeed - transform.position);
        }
        if (towardsPosition == transform.position)
        {
            
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