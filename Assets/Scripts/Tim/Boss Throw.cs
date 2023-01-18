using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossThrow : MonoBehaviour
{
    private float timer;
    [SerializeField]
    private GameObject bottlePrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 5)
        {
            timer = 0;
            Instantiate(bottlePrefab, transform.position, Quaternion.identity);
        }
    }
}
