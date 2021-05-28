using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Droper : MonoBehaviour
{
    MeshRenderer renderer;
    Rigidbody rigidbody;

    public float Waitime = 3f;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        rigidbody = GetComponent<Rigidbody>();

        renderer.enabled = false;
        rigidbody.useGravity = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > Waitime)
        {
            Debug.Log("3 secs crossed");
            rigidbody.useGravity = true;
            renderer.enabled = true;
        }
    }
 
}
