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
        UnityEditor.EditorApplication.isPlaying = false;
    }


    public static void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public static void ScoreLimit11()
    {
        //when score == 7 load next level
        if (Score.counter1 == 1)
        {
            LoadNextLevel();
        }
    }

    public static void ScoreLimit2()
    {
        //when score == 7 load next level
        if (Score.counter2 == 1)
        {
            LoadNextLevel();
        }
    }
}
