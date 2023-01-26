using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCamera : MonoBehaviour
{
    Vector3 worldMousePosition;
    Vector3 mousePosition;
    [SerializeField]
    Vector3 diffPos;
    [Range(1, 10)]
    public int Strength = 4;
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Input.mousePosition;
        worldMousePosition = Camera.main.ScreenToWorldPoint(mousePos);
        mousePosition = new Vector3(worldMousePosition.x, worldMousePosition.y, 0);

        diffPos = mousePosition - player.transform.position;
        if (diffPos.x > 12)
        {
            diffPos.x = 12;
        }
        else if (diffPos.x < -12)
        {
            diffPos.x = -12;
        }
        if (diffPos.y > 7)
        {
            diffPos.y = 7;
        }
        else if (diffPos.y < -7)
        {
            diffPos.y = -7;
        }
        diffPos.z = -10;
        gameObject.transform.position = player.transform.position + (diffPos / Strength);

    }
}
