using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Controls : MonoBehaviour
{
    public KeyCode moveUp = KeyCode.W;
    public KeyCode moveDown = KeyCode.S;
    public float velocity = 15.0f;
    public float boundY = 3.2f;
    private Rigidbody2D rb2d;

    // Use this for initialization
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        int mult = 0;
        if (Input.GetKey(moveUp))
        {
            mult += 1;
        }
        if (Input.GetKey(moveDown))
        {
            mult -= 1;
        }
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, mult * velocity);

        var pos = transform.position;
        if (pos.y > boundY)
        {
            pos.y = boundY;
        }
        else if (pos.y < -boundY)
        {
            pos.y = -boundY;
        }
        transform.position = pos;
    }
}
