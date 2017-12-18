using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{

    // Static makes use of the same instance for the same class
    static MusicPlayer myMusicPlayer = null;

    void Awake()
    {

        if (myMusicPlayer != null)
        {
            Debug.Log("Destroying Object: " + this.gameObject.GetInstanceID().ToString());
            //Destroys the new object created
            Destroy(this.gameObject);
        }
        else //myMusicPlayer = null
        {
            //starts the music again
            myMusicPlayer = this;
        }
        // this.gameObject is attached to the script(SoundObject)
        // DontDestroyOnLoad doesn't destroy the object when loading a new scene
        GameObject.DontDestroyOnLoad(this.gameObject);
    }
}
