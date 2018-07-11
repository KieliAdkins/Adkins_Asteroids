using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour {

    // Declaring our variables
    public float moveSpeed;
    private Transform tf;
    public float laserLifetime;

    // Use this for initialization
    void Start () {
        // Acquiring component for movement
        tf = GetComponent<Transform>();
        Destroy(gameObject, laserLifetime);
    }
	
	// Update is called once per frame
	void Update () {
        // Changing the position of the Game Object
        tf.position = tf.position + (Vector3.up * moveSpeed);

        // Destroying the laser after a set period of time
        Destroy(gameObject, laserLifetime);
    }
}
