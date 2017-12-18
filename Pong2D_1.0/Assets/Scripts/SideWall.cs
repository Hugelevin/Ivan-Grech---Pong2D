using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideWall : MonoBehaviour {

    public bool isLeftWall;

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.name == "Ball")
        {
            this.GetComponent<AudioSource>().Play();
            Score.WallHit(isLeftWall);
        }
    }
}
