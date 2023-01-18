using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayTest : MonoBehaviour
{
    public Vector3 worldMousePosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Input.mousePosition;
        worldMousePosition = Camera.main.ScreenToWorldPoint(mousePos);
        transform.position = new Vector3(worldMousePosition.x, worldMousePosition.y, 0);
    }
}
// Tim.B