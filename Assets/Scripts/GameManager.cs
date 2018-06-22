using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    // Defining variables
    public static GameManager instance;
    public Player player;
    public Laser laser;
    public List<AsteroidSpawn> spawn;

    // Player information variables
    public float score = 0;
    public int lives;

    // Use this for initialization
    void Awake() {
        // Ensuring that the Game manager is loaded
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        // Ensuring that the Game manager is not overwritten
        else
        {
            Destroy(this.gameObject);
        }
    }

    
    // Update is called once per frame
    void Update()
    {
        if (lives < 0)
        {
            OnDestroy();
        }
    }

    private void OnDestroy()
    {
        Application.Quit();
    }

}
