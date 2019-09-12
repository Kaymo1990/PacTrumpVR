using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeaderBoardScores : MonoBehaviour
{
    public static void createLeaderBoardEntries()
    {
        for (int i = 0; i < 10; i++)
        {
            PlayerPrefs.SetInt("HighScore" + i, 0);
            PlayerPrefs.SetString("Player" + i, "");
        } 
    }
}
