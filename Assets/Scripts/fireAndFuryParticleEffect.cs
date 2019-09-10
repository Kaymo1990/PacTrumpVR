using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireAndFuryParticleEffect : MonoBehaviour
{
    public bool trumpSpawned = false;
    public GameObject fireAndFuryEffect;
    public float xPos = 0.04f;
    public float zPos = -0.075f;
    public float yPos = -1.65f;
    public int scoreThreshold;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (trumpSpawned == false)
        {
            if (SumScore.Score >= scoreThreshold)
            {
                Instantiate(fireAndFuryEffect, new Vector3(xPos, yPos, zPos), Quaternion.identity);
                trumpSpawned = true;
            }
        }

        
    }
}
