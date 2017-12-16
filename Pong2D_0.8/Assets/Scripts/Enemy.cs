using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Vector3 startingPos;
    Transform trans;

    void Start()
    {
        trans = GetComponent<Transform>();
        startingPos = trans.position;
    }

    void Update()
    {
        trans.position = new Vector3(startingPos.x, startingPos.y -4 + Mathf.PingPong(Time.time, 8), startingPos.z);
    }
}
