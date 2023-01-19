using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossThrow : MonoBehaviour
{
    private float timer;
    [SerializeField]
    private GameObject bottlePrefab;
    [SerializeField, Range(1,10)]
    public int throwDelay = 5;
    private GameObject arm;
    private GameObject Aim;
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= (1 * throwDelay))
        {
            timer = 0;
            Instantiate(bottlePrefab, arm.transform.position, Quaternion.identity);
            Aim.transform.LookAt(player.transform.position);
        }
    }
}
