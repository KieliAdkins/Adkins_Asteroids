using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawn : MonoBehaviour {
    // Hazard variables
    public GameObject hazard;
    public List<GameObject> hazardList; 
    private int hazardCount = 2;
    public float spawnWait;
    public float startWait;
    public float waveWait;
    public List<GameObject> spawnList;

    private GameManager instance; 

    // Use this for initialization
    void Start()
    {
        StartCoroutine(SpawnWaves());
    }

    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(startWait);
        while (true)
        {
            for (int i = 0; i <= hazardCount; i++)
            {

                Vector3 spawnPoint = new Vector3(Random.Range(-3.35f, 3.35f), 5, 0);
                Quaternion spawnRotation = Quaternion.identity;
                spawnList.Add(Instantiate(hazard, spawnPoint, spawnRotation));
                yield return new WaitForSeconds(spawnWait);
            }
            yield return new WaitForSeconds(waveWait);
        }
    }
    
}
