using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bottle : MonoBehaviour
{
    private Rigidbody2D r2d;
    Player player;
    [SerializeField]
    private GameObject spinning;
    private Vector3 aimedLocation;
    // Start is called before the first frame update
    void Start()
    {
        r2d = gameObject.GetComponent<Rigidbody2D>();
        player = FindObjectOfType<Player>();
        aimedLocation = player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        spinning.transform.eulerAngles += new Vector3(0, 0, 400) * Time.deltaTime;

    }
}
