using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    // Defining variables
    public float moveSpeed;
    public float turnSpeed;
    private Transform tf;
    public GameObject laser;
    public Transform laserSpawn;
    internal Quaternion rotation;

    // Use this for initialization
    void Start()
    {
        // Acquiring component for movement
        tf = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        // if statement for up key controlled movement
        if (Input.GetKey(KeyCode.UpArrow))
        {
            tf.position = tf.position + (GetComponent<Transform>().up * moveSpeed);
        }

        // if statement for right key controlled movement
        if (Input.GetKey(KeyCode.RightArrow))
        {
            tf.position = tf.position + (GetComponent<Transform>().right * moveSpeed);
            tf.Rotate(0, -turnSpeed, 0);
        }

        // if statement for left key controlled movement
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            tf.position = tf.position - (GetComponent<Transform>().right * moveSpeed);
            tf.Rotate(0, turnSpeed, 0);
        }

        // if statement for down key controlled movement
        if (Input.GetKey(KeyCode.DownArrow))
        {
            tf.position = tf.position - (GetComponent<Transform>().up * moveSpeed);
        }

        // if statement for shooting movement
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(laser, laserSpawn.position, laserSpawn.rotation);
        }
    }

    void OnDestroy()
    {
        // Moving player back to the center of the game
        tf.position = Vector3.zero;

        // Player loses a life
        GameManager.instance.playerLives -= 1;
    }

}
