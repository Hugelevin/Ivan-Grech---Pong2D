using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public GUIText player1ScoreLabel, player2ScoreLabel;
    public static int player1Score, player2Score;

    void Start()
    {
        player1Score = 0;
        player2Score = 0;
    }   


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

    public void OnGUI()
    {
        player1ScoreLabel.text = "" + player1Score;
        player2ScoreLabel.text = "" + player2Score;
    }

    void Update()
    {

        if (player1Score == 7 || player2Score == 7)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
