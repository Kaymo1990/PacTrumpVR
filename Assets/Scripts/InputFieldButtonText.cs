using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InputFieldButtonText : MonoBehaviour
{
    public static List<string> Usernames = new List<string>();
    public static string Username;

    public Text buttonText;
    public InputField myField;
  
    public void updateText()
    {
        myField.text += buttonText.text;
    }
    public void backspace()
    {
        myField.text = myField.text.Remove(myField.text.Length - 1);       
    }
    public void space()
    {
        myField.text += " ";
    }
    public void enter()
    {
        Username = myField.text;
        SceneManager.LoadScene("LeaderBoard");
    }
}
