using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Addscore : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        Destroy(this.gameObject);

        SumScore.Add(10);

        SumScore.SaveHighScore();
    }
}
