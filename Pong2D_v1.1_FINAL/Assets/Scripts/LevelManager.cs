using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public void LoadLevel(string levelName)
    {
        Debug.Log("Level: " + levelName);
        //loads the scene named levelName
        SceneManager.LoadScene(levelName);
    }

    public void QuitGame()
    {
        Debug.Log("Quitting Game");
        UnityEditor.EditorApplication.isPlaying = false;
    }


    public static void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
