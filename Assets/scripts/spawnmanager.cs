using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnmanager : MonoBehaviour
{
    public GameObject[] pelotasPrefabs;
    private float spawnLimitXLeft = -120;
    private float spawnLimitXRight = 120;
    private float spawnPosY = 30;
    private float spawnPosZ = 92;

    private float startDelay = 1.0f;
    private float minSpawnInterval = 3f;
    private float maxSpawnInterval = 6f;

    
    void Start()
    {
        InvokeRepeating("SpawnRandomBall", startDelay, Random.Range(minSpawnInterval, maxSpawnInterval));
    }


    void SpawnRandomBall()
    {
        int randomballindex = Random.Range(0, pelotasPrefabs.Length);

        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, spawnPosZ);

        Instantiate(pelotasPrefabs[randomballindex], spawnPos, pelotasPrefabs[randomballindex].transform.rotation);
    }
}
