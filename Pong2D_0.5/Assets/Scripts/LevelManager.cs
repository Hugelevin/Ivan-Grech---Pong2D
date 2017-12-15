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


    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    /*public void BrickDestroyed()
    {
        //when all bricks are destroyed load next level
        if (Bricks.breakableCount <= 0)
        {
            LoadNextLevel();
        }
    }*/

    public GUIText player1ScoreLabel, player2ScoreLabel;
    private static int player1Score, player2Score;

    public static void WallHit(bool leftWall)
    {
        if (leftWall)
        {
            player2Score++;
        }
        else
        {
            player1Score++;
        }
    }

    void OnGUI()
    {
        player1ScoreLabel.text = "<b>Player 1 Score:</b> " + player1Score;
        player2ScoreLabel.text = "<b>Player 2 Score:</b> " + player2Score;
    }

}
