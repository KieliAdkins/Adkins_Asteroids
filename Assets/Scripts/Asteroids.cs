using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroids : MonoBehaviour {

    // Declaring the variables
    public float moveSpeed;
    private Transform tf;


    // Use this for initialization
    void Start () {
        // Getting component movement for the asteroid
        tf = GetComponent<Transform>();
    }
	
	// Update is called once per frame
	void Update () {
        // Asteroid movement
        tf.position = tf.position - (Vector3.up * moveSpeed * Time.deltaTime);
    }

    // On collision with objects
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // If object is not the boundary destroy the asteroid and what it is colliding with
        if (collision.gameObject.tag != "Boundary")
        {
            // Destroying the enemy and collision object
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
        // Adding 500 to player's score
        GameManager.instance.score += 200;
    }

}
