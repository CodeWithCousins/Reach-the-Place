using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public float yValue = 0;
    public float moveSpeed = 25f;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(-20.2f, 1.85f, -42.3f);
        PrintMessage();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue, yValue, zValue);
    }

    void PrintMessage()
    {
        Debug.Log("Welcome Game");
        Debug.Log("use WASD or Arrow keys to make the player move");
    }
}
