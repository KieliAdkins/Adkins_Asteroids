using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Defining variables
    public float moveSpeed;
    public float speed;
    public float turnSpeed;
    private Transform tf;

    // Use this for initialization
    void Start () {
        tf = GetComponent<Transform>();
    }
	
	// Update is called once per frame
	void Update () {
        // if statement for spacebar reset
        if (Input.GetKeyDown(KeyCode.Space))
        {
            tf.position = Vector3.zero;
        }

        // if statement for up key controlled movement
        if (Input.GetKey(KeyCode.UpArrow))
        {
            tf.position = tf.position + (GetComponent<Transform>().up * speed);
        }

        // if statement for down key controlled movement
        if (Input.GetKey(KeyCode.DownArrow))
        {
            tf.position = tf.position + (GetComponent<Transform>().up * speed);
        }

        // if statement for right key controlled movement
        if (Input.GetKey(KeyCode.RightArrow))
        {
            tf.position = tf.position + (GetComponent<Transform>().up * speed);
            tf.Rotate(0, 0, -turnSpeed);
        }

        // if statement for left key controlled movement
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            tf.position = tf.position + (GetComponent<Transform>().up * speed);
            tf.Rotate(0, 0, turnSpeed);
        }
    }
}
