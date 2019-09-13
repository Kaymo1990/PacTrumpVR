using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class AddUsernameAndScore : MonoBehaviour
{
    public static bool Changed = false;

    public int[] CopyOfLeaderboardScoresArray = new int[10];
    public string[] CopyOfLeaderboardNamesArray = new string[10];

    GameObject CreateText(Transform canvas_transform, float x, float y,
        string text_to_print, int font_size, Color text_color)
    {
        GameObject UItextGO = new GameObject("Text2");
        UItextGO.transform.SetParent(canvas_transform);

        RectTransform trans = UItextGO.AddComponent<RectTransform>();
        trans.anchoredPosition = new Vector2(x, y);
        trans.sizeDelta = new Vector2(1203, 44);

        Text text = UItextGO.AddComponent<Text>();
        text.text = text_to_print;
        text.fontSize = font_size;
        text.font = Resources.GetBuiltinResource<Font>("Arial.ttf");
        text.color = text_color;
        text.alignment = TextAnchor.MiddleCenter;

        return UItextGO;
    }

    void Start()
    {
		Changed = false;

        for (int i = 0; i < 10; i++)
        {
            if (PlayerPrefs.GetString("HighScore" + i) == null)
            {
                LeaderBoardScores.createLeaderBoardEntries();
            }
        }
        for(int i = 0; i < 10; i++)
        {
            CopyOfLeaderboardScoresArray[i] = PlayerPrefs.GetInt("HighScore" + i);
            CopyOfLeaderboardNamesArray[i] = PlayerPrefs.GetString("Player" + i);
            
        }

        for (int i = 0; i < 10; i++)
		{
            if  (SumScore.Score > PlayerPrefs.GetInt("HighScore" + i) && Changed == false)
            {            
                for (int j = i; j < 10; j++)
                {
                    PlayerPrefs.SetString("Player" + (j + 1), CopyOfLeaderboardNamesArray[j]);
                    PlayerPrefs.SetInt("HighScore" + (j + 1), CopyOfLeaderboardScoresArray[j]);                
                }

                PlayerPrefs.SetString("Player" + i, InputFieldButtonText.Username);
                PlayerPrefs.SetInt("HighScore" + i, SumScore.Score);
                CreateText(transform, 10, 321 - (71 * i), PlayerPrefs.GetString("Player" + i)
                    + ":\t" + PlayerPrefs.GetInt("HighScore" + i).ToString(), 25, Color.yellow);
                Changed = true;
            }

            else
            {
                CreateText(transform, 10, 321 - (71 * i), PlayerPrefs.GetString("Player" + i)
                    + ":\t" + PlayerPrefs.GetInt("HighScore" + i).ToString(), 25, Color.yellow);
            }
		}
    }

	private float timeLeft = 3.0f;

    void Update()
	{
		timeLeft -= Time.deltaTime;
		if (timeLeft <= 0)
			GameOver();
	}
    private void GameOver()
	{
		SceneManager.LoadScene("intro");
	}
}
