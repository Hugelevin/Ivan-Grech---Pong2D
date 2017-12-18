using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour {

    public GUIText player1ScoreLabel, player2ScoreLabel;
    public static int player1Score, player2Score;
    public static int counter1 = 0;
    public static int counter2 = 0;

    public static void WallHit(bool leftWall)
    {
        if (leftWall)
        {
            counter2++;
            player2Score++;
        }
        else
        {
            counter1++;
            player1Score++;
        }
    }

    void OnGUI()
    {
        player1ScoreLabel.text = "" + player1Score;
        player2ScoreLabel.text = "" + player2Score;
    }
}
