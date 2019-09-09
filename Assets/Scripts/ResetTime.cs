using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetTime : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
            SumPause.Status = !SumPause.Status;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
