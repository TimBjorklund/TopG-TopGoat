using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Animator animator;
    public SpriteRenderer sp;

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
    Vector3 worldMousePosition;
    Vector3 lookAtPosition;

    [SerializeField]
    GameObject lookAt;

    public float range = 4;
    public Healthbar healthbar; 


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
            
            animator.SetBool("isRunning", true);
            sp.flipX = true;

        }
        else if (Input.GetKey(right))
        {
            transform.position += new Vector3(speed, 0, 0) * Time.deltaTime;
            animator.SetBool("isRunning", true);
            sp.flipX = false;

        }
        else
        {
            animator.SetBool("isRunning", false);
        }
        if (Input.GetKeyDown(shoot))
        {
            if (haveWeapon == true)
            {
                Instantiate(weaponPrefab, transform.position, Quaternion.identity);
                haveWeapon = false;
            }
            animator.SetTrigger("Throw");
        }

        if (IsGrounded() && !Input.GetKey(jump))
        {
            dubbleJump = false;

            FindObjectOfType<AudioManager>().Play("Jump");
        }
        if (Input.GetKeyDown(jump))
        {
            Debug.Log("at Least trying");
            if (IsGrounded() || dubbleJump == true)
            {

                r2d.velocity = new Vector2(r2d.velocity.x, jumpPower);
                dubbleJump = !dubbleJump;
                Debug.Log("JUUUUUMP");

                if (AudioManager.instance != null)
                {
                    AudioManager.instance.Play("Jump");
                }
                
                animator.SetTrigger("Jump");
            }
            
        }
        if (Input.GetKeyUp(jump) && r2d.velocity.y > 0f)
        {
            r2d.velocity = new Vector2(r2d.velocity.x, r2d.velocity.y * 0.5f);
        }

       

        Vector3 mousePos = Input.mousePosition;
        mousePos.z = 0;
        worldMousePosition = Camera.main.ScreenToWorldPoint(mousePos);
        lookAtPosition = new Vector3(worldMousePosition.x, worldMousePosition.y, 0);
        lookAt.transform.LookAt(lookAtPosition);


        Vector3 direction = Vector3.forward;
        Ray playerRay = new Ray(transform.position, transform.TransformDirection(direction * range));
        Debug.DrawRay(transform.position, transform.TransformDirection(direction * range));

    }
    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.5f, groundLayer);
    }
}
// Tim.B