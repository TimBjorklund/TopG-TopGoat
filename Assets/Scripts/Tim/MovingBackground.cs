using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBackground : MonoBehaviour
{
    [SerializeField]
    private float MovingEffect;
    public GameObject Camera;
    private Vector3 CamerasLastPosition;

    // Start is called before the first frame update
    void Start()
    {
        CamerasLastPosition = Camera.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 heme = Camera.transform.position - CamerasLastPosition;
        transform.position += heme * MovingEffect;
        CamerasLastPosition = Camera.transform.position;
    }
}
