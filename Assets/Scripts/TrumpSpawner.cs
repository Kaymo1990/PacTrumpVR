using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrumpSpawner : MonoBehaviour
{

    public GameObject theEnemy;
    public float xPos = 0.04f;
    public float zPos = -0.075f;
    public float yPos = -1.65f;
    public int enemyCount;
    public int numberOfTrumps;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(EnemyDrop());
    }

    IEnumerator EnemyDrop()
    {
        while (enemyCount < numberOfTrumps)
        {
            Instantiate(theEnemy, new Vector3(xPos, yPos, zPos), Quaternion.identity);
            yield return new WaitForSeconds(5);
            enemyCount += 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
