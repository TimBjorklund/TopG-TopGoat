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
    [SerializeField]
    private GameObject background;
    [SerializeField]
    private GameObject playerBackground;
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
            playerCamera.enabled = false;
            bossCamera.enabled = true;
            playerBackground.SetActive(false);
            playedOnce = true;
        }
        else if (playedOnce == true)
        {
            gameObject.transform.position = Vector3.SmoothDamp(gameObject.transform.position, new Vector3(406, 15, -10), ref velocity, moveTime);
            if (bossCamera.orthographicSize < 15)
            {
                bossCamera.orthographicSize += 0.03f;
            }
            else if (bossCamera.orthographicSize > 15)
            {
                bossCamera.orthographicSize = 15;
            }
            if (background.transform.localScale.x < 8.6 || background.transform.localScale.y < 8.6)
            {
                background.transform.localScale += new Vector3(0.018f, 0.018f, 0f);
            }
        }
    }
}
