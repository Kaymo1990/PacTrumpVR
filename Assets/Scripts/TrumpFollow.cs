using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TrumpFollow : MonoBehaviour
{

    private NavMeshAgent TrumpAI;

    GameObject Player;

    public float TrumpAIDistanceRun = 4.0f;

    Animator animCon;


    // Start is called before the first frame update
    void Start()
    {
        TrumpAI = GetComponent<NavMeshAgent>();

        animCon = GetComponent<Animator>();

        Player = GameObject.FindGameObjectWithTag("Player");

    }

    // Update is called once per frame
    void Update()
    {


        float distance = Vector3.Distance(transform.position, Player.transform.position);

        if (distance < TrumpAIDistanceRun)
        {

            Vector3 dirToPlayer = transform.position - Player.transform.position;

            Vector3 newPos = transform.position - dirToPlayer;

            TrumpAI.SetDestination(newPos);

            animCon.SetBool("IsWalking", true);
        }
    }
}
