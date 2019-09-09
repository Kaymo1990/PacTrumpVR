using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHideMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject MenuObject;
    private bool Show = false;
    void Start()
    {
        MenuObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ShowAndHideMenu()
    {
        if (!Show)
        {
            MenuObject.SetActive(true);
            Show = true;
        }
        else
        {
            MenuObject.SetActive(false);
            Show = false;
        }
    }
}
