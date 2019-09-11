using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameComplete : MonoBehaviour
{
    public bool gameWon = false;
    // Start is called before the first frame update
    void Update()
    {
        if (gameWon == false)
        {
            if (SumScore.Score >= 3000)
            {
                SceneManager.LoadScene("Victory");
                gameWon = true;
            }
        }
    }
}
