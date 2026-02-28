using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    private float minSpawnInterval = 3.0f;
    private float maxSpawnInterval = 5.0f;
    private float intervalTime = 0f;
    private float nextTimerSpawn;
    private void Start()
    {
        nextTimerSpawn = Time.time + Random.Range(minSpawnInterval, maxSpawnInterval);
    }
    void Update()
    {
        if (Time.time >= nextTimerSpawn)
        {
            SpawnRandomBall();
            nextTimerSpawn = Time.time + Random.Range(minSpawnInterval, maxSpawnInterval);
        }
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall()
    {
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location
        int ballIndex = Random.Range(0, ballPrefabs.Length);
        Instantiate(ballPrefabs[ballIndex], spawnPos, ballPrefabs[ballIndex].transform.rotation);
    }
}
