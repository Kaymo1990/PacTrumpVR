using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossTrumpSpawner : MonoBehaviour
{

    public bool Spawned = false;
    public int thresholdScore;
    public GameObject bossTrump;
    public float xPos = 0.04f;
    public float zPos = -0.075f;
    public float yPos = -1.65f;
    public AudioClip fireAndFurySound;
    AudioSource audioSource;
    // Start is called before the first frame update


    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Spawned == false)
        {
            if (SumScore.Score >= thresholdScore)
            {
                Instantiate(bossTrump, new Vector3(xPos, yPos, zPos), Quaternion.identity);
                audioSource.PlayOneShot(fireAndFurySound, 1.0f);
                Spawned = true;
            }
        }
        
    }
}
