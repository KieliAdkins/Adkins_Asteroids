using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    // Defining variables
    public static GameManager instance;
    public Player player;
    public List<Enemy> enemies;
    public float score = 0;
    private int lives;

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
        // Lose Condition
        if (lives < 0)
        {
            DoGameOver();
        }
    }

    // Loop detailing lose condition
    void DoGameOver()
    {
        // TODO: Game over
    }

    void ResetGame()
    {
        // TODO: Game Reset
    }

}
