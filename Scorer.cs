using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hits = 0;
 
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "hit")
        {
            hits++;
            Debug.Log("The no of times player hits in the obstacle is" + hits);
            
        }
 
    }
}
