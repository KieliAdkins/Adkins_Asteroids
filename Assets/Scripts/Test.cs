using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    // Use this for initialization
    public List<GameObject> spawnList;
    public GameObject hazard;

    // Use this for initialization
    void Start()
    {


        spawnList = new List<GameObject>();
        InvokeRepeating("CheckAlive", 1, 1);

        //Populate for the first time
        for (int i = 0; i < 3; i++)
        {
            // Changed here AGAIN
            Vector3 spawnPosition = new Vector3(Random.Range(-3.35f, 3.35f), 5, 0);
            Quaternion spawnRotation = Quaternion.identity;
            spawnList.Add(Instantiate(hazard, spawnPosition, spawnRotation) as GameObject);
        }

    }
    

    void CheckAlive()
    {
        for (int i = 0; i < spawnList.Count; i++)
        {
            if (!spawnList[i])
            {
                // Also changed here AGAIN
                spawnList[i] = Instantiate(hazard) as GameObject;
            }
        }
    }
}
