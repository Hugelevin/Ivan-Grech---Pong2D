using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Controls : MonoBehaviour {

    public float boundY = 3.2f;

    private Vector3 offset;

    float xPos;

    void Awake()
    {
        xPos = transform.position.x;
    }

    void OnMouseDown()
    {

        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector2(xPos, Input.mousePosition.y));
    }

    void OnMouseDrag()
    {
        Vector2 newPosition = new Vector2(xPos, Input.mousePosition.y);
        transform.position = Camera.main.ScreenToWorldPoint(newPosition) + offset;
    }

    void Update()
    {
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
