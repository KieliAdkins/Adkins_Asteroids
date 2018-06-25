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
        //float step = moveSpeed * Time.deltaTime;
        //tf.position = Vector3.MoveTowards(tf.position, GameManager.instance.target.transform.position, step);

        //Transform tf = GetComponent<Transform>();                       // Get our Transform component
        //Vector3 newPosition = Vector3.Lerp(tf.position, GameManager.instance.target.transform.position, 0.1f);  // Find 10% of the way to pointB
        //tf.position = newPosition;
        // Declaring our asteroid's movement
        tf.position = tf.position - (Vector3.up * moveSpeed * Time.deltaTime);


        // Declaring our asteroid's rotation
        //Vector3 vectorToTarget = GameManager.instance.target.transform.position - tf.position;
        //float angle = Mathf.Atan2(vectorToTarget.y, vectorToTarget.x) * Mathf.Rad2Deg;
        //Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
        //tf.rotation = Quaternion.Slerp(tf.rotation, q, Time.deltaTime * 3);

        // Declaring our enemy's movement
        //float step = moveSpeed * Time.deltaTime;
        //tf.position = Vector3.MoveTowards(tf.position, GameManager.instance.target.transform.position, step);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // if statement regarding colliding into an object that is not an asteroid
        if (collision.gameObject.tag != "Boundary")
        {
            // Destroying asteroid and collision object
            Destroy(collision.gameObject);
            Destroy(gameObject);

            // Adding points to player's score
            GameManager.instance.score += 100;
        }
    }

}
