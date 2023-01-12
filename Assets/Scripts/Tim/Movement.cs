using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    KeyCode left;
    [SerializeField]
    KeyCode right;
    [SerializeField]
    KeyCode shoot;
    public GameObject weaponPrefab;
    public bool haveWeapon = true;
    public float speed = 4f;
    public float gravity = 9.82f;
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
            }

        }
    }
}
