using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartTweet : MonoBehaviour
{
    public bool showNukeImage = false;
    public bool imageShown = true;
    private Image myImage;
    void Start()
    {
        myImage = GetComponent<Image>();
        myImage.enabled = true;
    }

    void Update()
    {
        if (imageShown == true)
        {
            StartCoroutine(BlinkNukeIcon(2.5f));
            imageShown = false;
        }

    }

    IEnumerator BlinkNukeIcon(float delayInSecs)
    {
        myImage.enabled = true;
        yield return new WaitForSeconds(delayInSecs);
        myImage.enabled = false;
        showNukeImage = false;
    }
}
