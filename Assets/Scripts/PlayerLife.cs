using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    public Transform teleportTarget;
    public Transform teleportTargetTrump;
    public GameObject thePlayer;
    private GameObject[] trump;

    PlayerHealth playerHealth;



    // Start is called before the first frame update

    private void Start()
    {
        playerHealth = thePlayer.GetComponent<PlayerHealth>();

    }

    void OnTriggerEnter(Collider other)
    {
        //if(SumScoreManager.Lives == 0)
        //{
        //    SceneManager.LoadScene("intro");
        //}
        playerHealth.TakeDamage(1);
        trump = GameObject.FindGameObjectsWithTag("Trump");
        foreach (GameObject t in trump)
            t.transform.position = teleportTargetTrump.transform.position;
        thePlayer.transform.position = teleportTarget.transform.position;
        print("TESTER!");

    }
  


}
