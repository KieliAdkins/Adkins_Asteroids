using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour {
    // Declaring the variables
    public float moveSpeed;
    private Transform tf;


    // Use this for initialization
    void Start()
    {
        // Getting component movement for the asteroid
        tf = GetComponent<Transform>();


    }

    // Update is called once per frame
    void Update()
    {

        // Declaring our asteroid's movement
        tf.position = tf.position - (Vector3.up * moveSpeed * Time.deltaTime);
    }

    // Destroy sequence
    void OnDestroy()
    {
        GameManager.instance.score += 100;
    }
}

