using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossFightCamera : MonoBehaviour
{
    private Boss boss;
    public Transform playerCameraT;
    private bool playedOnce = false;
    public Camera playerCamera;
    public Camera bossCamera;
    private Vector3 moveDistance;
    [SerializeField, Range(1,10)]
    private float moveTime = 1;
    private Vector3 velocity;
    // Start is called before the first frame update
    void Start()
    {        playerCamera.enabled = true;
        bossCamera.enabled = false;
        boss = FindObjectOfType<Boss>();
        velocity = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        if (boss.playerInBox == 1 && playedOnce == false)
        {
            gameObject.transform.position = playerCameraT.position;
            playedOnce = true;
        }
        else if (playedOnce == true)
        {
            gameObject.transform.position = Vector3.SmoothDamp(gameObject.transform.position, new Vector3(406, 10, -10), ref velocity, moveTime);
        }
    }
}
