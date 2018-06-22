using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour {
    // Declaring our variables
    public static GameObject laser;
    public float moveSpeed;
    private Transform tf;

    // Use this for initialization
    void Start()
    {
        // Acquiring component for movement
        tf = GetComponent<Transform>();
    }

	// Update is called once per frame
	void Update () {
        // Changing the position of the Game Object
        tf.position = tf.position + (Vector3.up * moveSpeed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
