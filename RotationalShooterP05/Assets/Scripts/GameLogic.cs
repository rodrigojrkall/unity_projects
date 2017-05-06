using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic : MonoBehaviour
{

    public GameObject enemyToSpawn;

    public bool canEnemySpawn = true;
    public float enemySpawnTimeFLOAT0 = 1.0f;
    public float enemySpawnTimeFLOAT1 = 4.6f;
    public float enemySpawnTimeFLOAT2 = 2.0f;
    public float enemySpawnTimeFLOAT3 = 3.6f;

    void Start()
    {
        StartCoroutine(enemySpawnTimer0());
        StartCoroutine(enemySpawnTimer1());
        StartCoroutine(enemySpawnTimer2());
        StartCoroutine(enemySpawnTimer3());
    }

    void Update()
    {

    }

    IEnumerator enemySpawnTimer0()
    {
        while (canEnemySpawn)
        {
            spawnEnemy0();
            yield return new WaitForSeconds(enemySpawnTimeFLOAT0);
        }
    }
    IEnumerator enemySpawnTimer1()
    {
        while (canEnemySpawn)
        {
            spawnEnemy1();
            yield return new WaitForSeconds(enemySpawnTimeFLOAT1);
        }
    }
    IEnumerator enemySpawnTimer2()
    {
        while (canEnemySpawn)
        {
            spawnEnemy2();
            yield return new WaitForSeconds(enemySpawnTimeFLOAT2);
        }
    }
    IEnumerator enemySpawnTimer3()
    {
        while (canEnemySpawn)
        {
            spawnEnemy3();
            yield return new WaitForSeconds(enemySpawnTimeFLOAT3);
        }
    }

    void spawnEnemy0()
    {
        Instantiate(enemyToSpawn, new Vector3(-38, 18, 0), Quaternion.identity);
    }

    void spawnEnemy1()
    {
        Instantiate(enemyToSpawn, new Vector3(-38, -18, 0), Quaternion.identity);
    }

    void spawnEnemy2()
    {
        Instantiate(enemyToSpawn, new Vector3(38, -18, 0), Quaternion.identity);
    }

    void spawnEnemy3()
    {
        Instantiate(enemyToSpawn, new Vector3(38, 18, 0), Quaternion.identity);
    }
}
