using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spinner : MonoBehaviour
{
    public float xValue = 0f;
    public float yValue = 2f;
    public float zValue = 0f;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.tag != "hit")
        {
            gameObject.GetComponent<Transform>().Rotate(0, 1, 0);
        }

        else if (gameObject.tag == "hit")
        {
            gameObject.GetComponent<Transform>().Rotate(0, 0, 0);
        }
        
    }
}
