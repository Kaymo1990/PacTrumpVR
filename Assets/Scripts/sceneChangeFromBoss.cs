using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sceneChangeFromBoss : MonoBehaviour
{
    public Material normalSkyBox;
    public Material bossTrumpSkyBox;
    public bool Skyboxchanged = false;
    public int SceneChangeThreshold;
    // Start is called before the first frame update
    void Start()
    {
        RenderSettings.skybox = normalSkyBox;
    }

    // Update is called once per frame
    void Update()
    {
        if (Skyboxchanged == false)
        {
            if (SumScore.Score >= SceneChangeThreshold)
            {
                RenderSettings.skybox = bossTrumpSkyBox;
            }
        }
    }
}
