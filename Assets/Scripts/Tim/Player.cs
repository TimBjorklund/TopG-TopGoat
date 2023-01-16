using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    KeyCode left;
    [SerializeField]
    KeyCode right;
    [SerializeField]
    KeyCode shoot;
    [SerializeField]
    KeyCode jump;

    //Jumping
    [SerializeField] 
    private Transform groundCheck;
    [SerializeField] 
    private LayerMask groundLayer;
    private Rigidbody2D r2d;
    public float jumpPower = 4f;
    public bool dubbleJump;

    //Weapon
    public GameObject weaponPrefab;
    public bool haveWeapon;
    public float speed = 4f;

    [SerializeField]
    GameObject lookAt;

    public float range = 4;
    // Start is called before the first frame update
    void Start()
    {
        r2d = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(left))
        {
            transform.position -= new Vector3(speed, 0, 0) * Time.deltaTime;
        }
        else if (Input.GetKey(right))
        {
            transform.position += new Vector3(speed, 0, 0) * Time.deltaTime;
        }
        if (Input.GetKeyDown(shoot))
        {
            if (haveWeapon == true)
            {
                Instantiate(weaponPrefab, transform.position, Quaternion.identity);
                haveWeapon = false;
            }
        }

        if (Input.GetKeyDown(jump))
        {
            Debug.Log("at Least trying");
            if (IsGrounded() || dubbleJump == true)
            {
                r2d.velocity = new Vector2(r2d.velocity.x, jumpPower);
                dubbleJump = !dubbleJump;
                Debug.Log("JUUUUUMP");
            }
        }
        if (Input.GetKeyUp(jump) && r2d.velocity.y > 0f)
        {
            r2d.velocity = new Vector2(r2d.velocity.x, r2d.velocity.y * 0.5f);
        }



        Vector3 mouseScreenPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        lookAt.transform.LookAt(mouseScreenPosition);

        /*
        Vector3 direction = Vector3.forward;
        Ray playerRay = new Ray(transform.position, transform.TransformDirection(direction * range));
        Debug.DrawRay(transform.position, transform.TransformDirection(direction * range));*/

        /*if (Physics.Raycast(playerRay, out RaycastHit hit, range))
        {

        }*/
    }
    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }
}
