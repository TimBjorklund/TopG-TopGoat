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
    public GameObject weaponPrefab;
    public bool haveWeapon;
    public float speed = 4f;
    public float gravity = 9.82f;

    [SerializeField]
    GameObject lookAt;

    public float range = 4;
    // Start is called before the first frame update
    void Start()
    {

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
}
