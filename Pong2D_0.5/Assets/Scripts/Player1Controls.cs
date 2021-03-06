﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Controls : MonoBehaviour {

    public KeyCode moveUp = KeyCode.W;
    public KeyCode moveDown = KeyCode.S;
    public float velocity = 10.0f;
    public float boundY = 3.2f;
    private Rigidbody2D rb2d;

    // Use this for initialization
    void Start () {
        rb2d = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        var vel = rb2d.velocity;
        if (Input.GetKey(moveUp))
        {
            vel.y = velocity;
        }
        else if (Input.GetKey(moveDown))
        {
            vel.y = -velocity;
        }
        else if (!Input.anyKey)
        {
            vel.y = 0;
        }
        rb2d.velocity = vel;

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
