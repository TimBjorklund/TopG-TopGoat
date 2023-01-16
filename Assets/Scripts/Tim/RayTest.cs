using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayTest : MonoBehaviour
{
    [SerializeField]
    GameObject lookAt;
    public Vector3 worldMousePosition;
    public float range;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = 0;
        worldMousePosition = Camera.main.ScreenToWorldPoint(mousePos);
        transform.position = worldMousePosition;
    }
}
