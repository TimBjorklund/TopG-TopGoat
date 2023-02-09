using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bottle : MonoBehaviour
{
    [SerializeField]
    private GameObject spinning;
    private Vector3 direction;
    public Vector3 startingPos;
    [SerializeField]
    private GameObject aim;
    private Vector3 aimedPos;

    private Rigidbody2D r2d;
    public Vector3 currentForce;
    // Start is called before the first frame update
    void Start()
    {
        aim = GameObject.FindGameObjectWithTag("AndrewAim");
        aimedPos = aim.transform.position;
        startingPos = transform.position;
        direction = aimedPos - startingPos;
        
    }

    // Update is called once per frame
    void Update()
    {
        spinning.transform.eulerAngles += new Vector3(0, 0, 400) * Time.deltaTime;
        transform.position += direction/5;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            Destroy(gameObject);
        }
    }
}
