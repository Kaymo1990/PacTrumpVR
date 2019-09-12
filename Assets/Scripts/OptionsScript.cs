using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject theMaze;
   //public GameObject Trump;
    void Start()
    {
        if (PlayerPrefs.GetString("Low Walls", "FALSE") == "TRUE")
        { theMaze.transform.localScale -= new Vector3(0, 1.5F, 0);
           // Trump.transform.localScale = new Vector3(1, 1.35f, 1); 
            }
        if (PlayerPrefs.GetString("Low Walls") == "FALSE")
        {

          // Trump.transform.localScale = new Vector3(1, 1, 1);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
