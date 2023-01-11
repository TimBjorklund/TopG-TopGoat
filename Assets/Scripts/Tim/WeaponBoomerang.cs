using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponBoomerang : MonoBehaviour
{
    private Rigidbody2D r2d;
    public GameObject playerTarget;
    // Start is called before the first frame update
    void Start()
    {
        r2d = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        r2d.AddForce(playerTarget.transform.position - transform.position);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //if ()
    }
}
