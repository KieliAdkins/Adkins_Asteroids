using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    // Defining variables
    public static GameManager instance;
    public int playerLives;
    public int score;
    public List<GameObject> enemyList = new List<GameObject>();
    private int numEnemySpawned;
    private int numToSpawn = 4;

    internal Quaternion rotation;
    public GameObject target; 


    // Use this for initialization and destruction of duplicate Game Managers
    void Awake()
    {

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

        // Filling array with prefabs
        Object[] enemyPrefab = Resources.LoadAll("Prefabs", typeof(GameObject));

        foreach (GameObject enemy in enemyPrefab)
        {
            GameObject tempEnemy = (GameObject)enemy;
            enemyList.Add(tempEnemy);
        }
    }

    // Spawning the enemy
    void SpawnEnemy()
    {
        // If there are less than 3 enemies spawned create more
        if (numEnemySpawned <= numToSpawn)
        {
            int whichItem = Random.Range(0, enemyList.Count);
            Vector3 spawnPoint = new Vector3(Random.Range(-3.35f, 3.35f), 5, 0);
            Quaternion spawnRotation = Quaternion.identity;
            GameObject myEnemy = Instantiate(enemyList[whichItem], spawnPoint, spawnRotation) as GameObject;
            myEnemy.transform.position = spawnPoint;
            numEnemySpawned++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Calling the function to instantiate enemies
        SpawnEnemy();


        // Quitting the application if the player has no lives
        if (playerLives < 0)
        {
            Application.Quit();
        }
	}
}
