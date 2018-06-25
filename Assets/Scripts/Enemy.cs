using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    // Declaring our variables
    public float moveSpeed;
    public float turnSpeed;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        // Declaring our enemy's rotation
        Vector3 vectorToTarget = GameManager.instance.target.transform.position - transform.position;
        float angle = Mathf.Atan2(vectorToTarget.y, vectorToTarget.x) * Mathf.Rad2Deg;
        Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, q, Time.deltaTime * turnSpeed);

        // Declaring our enemy's movement
        float step = moveSpeed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, GameManager.instance.target.transform.position, step);
    }

    // Destroying the enemy on contact
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (gameObject.tag != "Boundary")
        {
            // Destroying the enemy and collision object
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
        // Adding 500 to player's score
        GameManager.instance.score += 500;
    }
}
