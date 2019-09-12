using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuOptionsScript : MonoBehaviour
{
    public GameObject LowButton;
    public GameObject HighButton;
    //public GameObject Trump;
    // Start is called before the first frame update
    void Start()
    {
        //check if playerprefs are uninitialised, if they are then set them to highwall mode
        if (PlayerPrefs.GetString("Low Walls", "FALSE") == "FALSE")
        {   PlayerPrefs.SetString("Low Walls", "FALSE");
            Image image = HighButton.GetComponent<Image>();
            image.color = new Color(245f, 255f, 0f, 0.47f);
            Image imageL = LowButton.GetComponent<Image>();
            imageL.color = new Color(245f, 255f, 0f, 0.09f);
            //Trump.transform.localScale = new Vector3(1, 1, 1);
        }
        else
        {
            Image image = HighButton.GetComponent<Image>();
            image.color = new Color(245f, 255f, 0f, 0.09f);
            Image imageL = LowButton.GetComponent<Image>();
            imageL.color = new Color(245f, 255f, 0f, 0.47f);
           //Trump.transform.localScale = new Vector3(1, 1.35f, 1);
        }

    }
    public void SelectLowWalls()
    {
        PlayerPrefs.SetString("Low Walls", "TRUE");
        Image imageL = LowButton.GetComponent<Image>();
        imageL.color = new Color(245f, 255f, 0f, 0.47f);
        Image imageH = HighButton.GetComponent<Image>();
        imageH.color = new Color(245f, 255f, 0f, 0.09f);
        //Trump.transform.localScale = new Vector3(1, 1.35f, 1);
    }
    public void SelectHighWalls()
    {
        PlayerPrefs.SetString("Low Walls", "FALSE");
        Image imageL = LowButton.GetComponent<Image>();
        imageL.color = new Color(245f, 255f, 0f, 0.09f);
        Image imageH = HighButton.GetComponent<Image>();
        imageH.color = new Color(245f, 255f, 0f, 0.47f);
       // Trump.transform.localScale = new Vector3(1, 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
