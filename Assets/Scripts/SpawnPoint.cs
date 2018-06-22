using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour {

    // Spawn Variables
    public List<GameObject> spawnList;
    public GameObject spawnPoint;
    private Transform tf;
    private int hazardCount = 2;
    public float spawnWait;
    public float startWait;
    public float waveWait;

    private GameManager instance;


    // Use this for initialization
    void Start()
    {
        spawnList = new List<GameObject>();

        StartCoroutine(SpawnPoints());

    }



    IEnumerator SpawnPoints()
    {
        yield return new WaitForSeconds(startWait);
        while (true)
        {
            for (int i = 0; i <= hazardCount; i++)
            {
                Vector3 spawnPosition = new Vector3(Random.Range(-3.35f, 3.35f), 5, 0);
                Quaternion spawnRotation = Quaternion.identity;
                spawnList.Add(Instantiate(spawnPoint, spawnPosition, spawnRotation) as GameObject);
                yield return new WaitForSeconds(spawnWait);
            }
            yield return new WaitForSeconds(waveWait);
        }
    }

}


