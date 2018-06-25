using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    // Defining variables
    public static GameManager instance;
    public int playerLives;
    public int score;
    public List<GameObject> enemyList = new List<GameObject>();
    private int numEnemySpawned = 0;
    private int numToSpawn = 2;
    public Transform spawnPoint; 

    public float spawnWait;
    public float startWait;
    public float waveWait;

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


    void spawnEnemy()
    {
        for (int i = 0; i < numToSpawn; i++)
        {
            int whichItem = Random.Range(0, enemyList.Count - 1);
            Vector3 spawnPoint = new Vector3(Random.Range(-3.35f, 3.35f), 5, 0);
            Quaternion spawnRotation = Quaternion.identity;
            GameObject myEnemy = Instantiate(enemyList[whichItem], spawnPoint, spawnRotation) as GameObject;
            myEnemy.transform.position = transform.position;
            numEnemySpawned++;
        }
    }

    // Update is called once per frame
    void Update()
    {

        if (numToSpawn > numEnemySpawned)
        {
            transform.position = spawnPoint.transform.position;
            spawnEnemy();
        }

        if (playerLives < 0)
        {
            Application.Quit();
        }
	}

    /* Coroutine to spawn enemy waves
    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(startWait);
        while (true)
        {
            for (int i = 0; i < 1; i++)
            {
                int whichItem = Random.Range(0,enemyList.Count - 1);
                Vector3 spawnPoint = new Vector3(Random.Range(-3.35f, 3.35f), 5, 0);
                Quaternion spawnRotation = Quaternion.identity;
                GameObject myEnemy = Instantiate(enemyList[whichItem], spawnPoint, spawnRotation) as GameObject;
                myEnemy.transform.position = transform.position;
                yield return new WaitForSeconds(spawnWait);
                numEnemySpawned++;
            }
            yield return new WaitForSeconds(waveWait);
        }
    }*/
}
