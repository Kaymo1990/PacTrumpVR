using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnControllerColliderHit(ControllerColliderHit col)     {         if (col.gameObject.name == "TrumpAI" || col.gameObject.name == "TrumpAI(Clone)")
        {             SceneManager.LoadScene("intro"); ;

        }

    }
}
