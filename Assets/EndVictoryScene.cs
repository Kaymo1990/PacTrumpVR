using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndVictoryScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private float timeLeft = 3.0f;
    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft <= 0)
        {
                GameOver();
        }
        void GameOver()
        {
            SceneManager.LoadScene("intro");
        }
    }
}
