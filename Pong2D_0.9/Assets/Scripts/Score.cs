using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour {

    public static int counter = 0;
    public GUIText player1ScoreLabel, player2ScoreLabel;
    private static int player1Score, player2Score;

    public static void WallHit(bool leftWall)
    {
        if (leftWall)
        {
            player2Score++;
            counter++;
        }
        else
        {
            player1Score++;
            counter++;
        }
    }

    void OnGUI()
    {
        player1ScoreLabel.text = "" + player1Score;
        player2ScoreLabel.text = "" + player2Score;
    }
}
