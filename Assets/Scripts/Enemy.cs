using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
    // Declaring our variables
    public float moveSpeed;
    public float turnSpeed;
    public GameObject target;

    // Use this for initialization
    void Start ()
    {
    }
	
	// Update is called once per frame
	void Update () {
        // Declaring our asteroid's movement

        float rStep = turnSpeed * Time.deltaTime;
        transform.rotation = Quaternion.RotateTowards(transform.rotation, target.transform.rotation, rStep);

        float step = moveSpeed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, step);
    }

    // Destroy sequence
    void OnDestroy()
    { 
        GameManager.instance.score += 500;
    }

}
