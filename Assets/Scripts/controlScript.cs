using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class controlScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    public void ChangeScene()
    {
        SceneManager.LoadScene("PacTrump2.1");
    }
    public void ChangeSceneToIntro()
    {
        SceneManager.LoadScene("intro");
    }
    public void ChangeSceneToOptions()
    {
        SceneManager.LoadScene("options");
    }
    public void ChangeSceneToPlayWithLowWalls()
    {
        PlayerPrefs.SetString("Low Walls", "TRUE");
        SceneManager.LoadScene("PacTrump2.1");
    }
}
